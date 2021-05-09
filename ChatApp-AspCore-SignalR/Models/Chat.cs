using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp_AspCore_SignalR.Models
{
    public class Chat
    {
        public Chat()
        {
            Users = new List<User>();
            Messages = new List<Message>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<User> Users { get; set; }
        public ChatType Type { get; set; }
    }
}
