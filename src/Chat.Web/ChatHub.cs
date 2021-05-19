using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Chat.Web
{
    public class ChatHub : Hub
    {
        private readonly State _state;
        public ChatHub (State state)
        {
            _state = state;
        }
        public async Task SendMessage (string message, User User)
        {
            _state.Messages.Add(new() { Text = message, User = User });
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
