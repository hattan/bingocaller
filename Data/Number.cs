namespace BingoCaller.Data
{
    public class Number : IComparable<Number>
    {
        public int Value { get; set; }
        public bool Status { get; set; }
        public int CompareTo(Number num)
        {
            if (this.Value > num.Value)
            {
                return 1;
            }
            else if (this.Value < num.Value)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}