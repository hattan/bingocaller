using Microsoft.AspNetCore.SignalR;

namespace BingoCaller.Data
{
    public class Counter : ICounter
    {
        public List<Number> numbers = new List<Number>();
        public void Add(Number num)
        {
             numbers.Add(num);
        }

        public void Clear()
        {
            numbers.Clear();
        }

        public int Count()
        {
             return numbers.Count();
        }

        public List<Number> Get()
        {
            return numbers;
        }
    }
}