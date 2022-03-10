using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool StockAvailability { get; set; }
        public DateTime StockLastAdded { get; set; }
        public int StockID { get; set; }
        public decimal StockPrice { get; set; }
        public object StockName { get; set; }
        public object StockDescription { get; set; }
    }
}