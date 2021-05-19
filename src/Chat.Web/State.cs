using System;
using System.Collections.Generic;

namespace Chat.Web
{
    public class State
    {
        public List<Message> Messages { get; set; }

        public State ()
        {
            Messages = new();
        }
    }

    public class User
    {
        public string Id { get; set; }
        public string Username { get; set; }

        public User ()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
    public class Message
    {
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }

        public Message ()
        {
            User = new();
            Date = DateTime.Now;
        }

    }
}
