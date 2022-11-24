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
        public void Remove(Number num){
            var numbersToRemove = numbers.Where(n=>n.Value == num.Value);
            foreach(var number in numbersToRemove.ToList()){
                numbers.Remove(number);
            }
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