using ChatApp_AspCore_SignalR.Database;
using ChatApp_AspCore_SignalR.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp_AspCore_SignalR.ViewComponents
{
    public class RoomViewComponent : ViewComponent
    {
        private ChatContext _ctx { get; set; }
        public RoomViewComponent(ChatContext ctx)
        {
            _ctx = ctx;
        }

        public IViewComponentResult Invoke()
        {
            IEnumerable<Chat> chats = _ctx.Chats; 
            return View(chats);
        }
    }
}
