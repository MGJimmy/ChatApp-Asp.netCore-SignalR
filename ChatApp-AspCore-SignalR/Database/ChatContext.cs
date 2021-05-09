using ChatApp_AspCore_SignalR.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp_AspCore_SignalR.Database
{
    public class ChatContext : IdentityDbContext<User>
    {
        public ChatContext(DbContextOptions<ChatContext> options) : base(options)
        {
        }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
