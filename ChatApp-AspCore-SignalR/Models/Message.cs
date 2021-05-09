using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp_AspCore_SignalR.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }

        [ForeignKey("Chat")]
        public int ChatId { get; set; }
        public Chat Chat { get; set; }

        [ForeignKey("Sender")]
        public string SenderId { get; set; }
        public User Sender { get; set; }
    }
}
