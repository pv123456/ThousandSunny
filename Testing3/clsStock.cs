using System;

namespace Testing3
{
    class clsStock
    {
        public bool StockAvalibility { get; internal set; }
        public DateTime StockLastAdded { get; internal set; }
        public string StockName { get; internal set; }
        public string StockDescription { get; internal set; }
        public decimal StockPrice { get; internal set; }
    }
}