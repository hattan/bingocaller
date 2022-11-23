namespace BingoCaller.Data {
    public interface ICounter{
        void Add(Number num);
        void Remove(Number num);
        void Clear();
        int Count();
        List<Number> Get();
    }
}