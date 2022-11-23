using Microsoft.AspNetCore.SignalR;
using BingoCaller.Data;

namespace BingoCaller.Hubs
{
    public class GameHub : Hub
    {
        private ICounter _counter;
        public GameHub(ICounter counter)
        {
            _counter = counter;
        }
        public async Task CallNumber(string number, string status)
        {
            var currentNumber = new Number
            {
                Value = int.Parse(number),
                Status = status.ToLower() == "true"
            };

            if (!currentNumber.Status)
            {
                _counter.Add(currentNumber);
            }
            else{
                _counter.Remove(currentNumber);
            }

            await Clients.All.SendAsync("NumberCalled", number, status);
        }

        public async Task NewGame()
        {
            _counter.Clear();
            await Clients.All.SendAsync("NewGame");
        }

        public override async Task OnConnectedAsync()
        {
            foreach (var number in _counter.Get())
            {
                await Clients.All.SendAsync("NumberCalled", number.Value.ToString(), number.Status.ToString());
            }
            await base.OnConnectedAsync();
        }
    }

}