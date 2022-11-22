using Microsoft.AspNetCore.SignalR;

namespace BingoCaller.Data
{
    public class Counter
    {
        public static List<Number> numbers = new List<Number>();
        public static void Add(Number num)
        {
            numbers.Add(num);
        }
        public static void Clear()
        {
            numbers.Clear();
        }
        public static int Count()
        {
            return numbers.Count();
        }
        public static List<Number> Get()
        {
            return numbers;
        }
    }
}