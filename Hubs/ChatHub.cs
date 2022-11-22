using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{

    public class ChatHub : Hub
    {

     public async Task SendMessage(string number, string status)
        {
            Counter.Add(new Number{
                Value=int.Parse(number),
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
            foreach(var number in Counter.Get()){
                await Clients.All.SendAsync("ReceiveMessage", number.Value.ToString(), number.Status.ToString());
            }
            await base.OnConnectedAsync();
        }
    }
    public class Counter{
        public static List<Number> numbers = new List<Number>();
        public static void Add(Number num){
            numbers.Add(num);
        }
        public static void Clear(){
            numbers.Clear();
        }
        public static int Count(){
            return numbers.Count();
        }
        public static  List<Number> Get(){
            return numbers;
        }
    }
    public class Number{
        public int Value { get; set; }
        public bool Status { get; set; }
    }
}