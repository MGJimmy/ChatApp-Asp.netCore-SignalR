using ChatApp_AspCore_SignalR.Database;
using ChatApp_AspCore_SignalR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp_AspCore_SignalR.Controllers
{
    public class ChatController : Controller
    {
        private ChatContext _ctx { get; set; }
        public ChatController(ChatContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index(int id)
        {
            Chat chat = _ctx.Chats
                .Include(c=>c.Messages)
                .FirstOrDefault(c => c.Id == id);
            ViewBag.chat = chat;
            return View(chat);
        }
        public async Task<IActionResult> CreateRoom(string roomName)
        {
            Chat chat = new Chat()
            {
                Name = roomName,
                Type = ChatType.Room
            };
            _ctx.Chats.Add(chat);
            await _ctx.SaveChangesAsync();
            TempData["successMsg"] = "Room created successfully";
            return RedirectToAction("Index", "Home", new { id = chat.Id});
        }
        public async Task<IActionResult> sendMessage(string messageBody, int chatId)
        {
            _ctx.Messages.Add(new Message()
            {
                ChatId = chatId,
                Text = messageBody,
                Time = DateTime.Now
            });
            await _ctx.SaveChangesAsync();
            return RedirectToAction("Index","Home", new { id = chatId });
        }
    }
}
