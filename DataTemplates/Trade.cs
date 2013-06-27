using System;

namespace DataTemplates
{
    public class Trade
    {
        public int Id { get; set; }
        public DateTime DealDate { get; set; }
        public decimal Price { get; set; }
        public Type Type { get; set; }
        public decimal Price2Leg { get; set; }
    }

    public enum Type
    {
        NotSet = 0,
        Option,
        Swap,
        Forward
    }
}
