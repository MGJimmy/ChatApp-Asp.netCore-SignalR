using ChatApp_AspCore_SignalR.Database;
using ChatApp_AspCore_SignalR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp_AspCore_SignalR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ChatContext _ctx { get; set; }

        public HomeController(ILogger<HomeController> logger, ChatContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            IEnumerable<Chat> chats = _ctx.Chats;
            return View(chats);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
