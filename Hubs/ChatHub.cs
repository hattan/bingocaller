using Microsoft.AspNetCore.SignalR;
using BingoCaller.Data;

namespace BingoCaller.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string number, string status)
        {
            Counter.Add(new Number
            {
                Value = int.Parse(number),
                Status = status == "true"
            });
            await Clients.All.SendAsync("ReceiveMessage", number, status);
        }

        public async Task NewGame()
        {
            Counter.Clear();
            await Clients.All.SendAsync("NewGame");
        }

        public override async Task OnConnectedAsync()
        {
            foreach (var number in Counter.Get())
            {
                await Clients.All.SendAsync("ReceiveMessage", number.Value.ToString(), number.Status.ToString());
            }
            await base.OnConnectedAsync();
        }
    }

}