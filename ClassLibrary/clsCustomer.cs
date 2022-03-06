using System;
namespace ClassLibrary
{
    public class clsCustomer
    {
        public int CustId { get; set; }
        public string CustUsername { get; set; }
        public string CustPassword { get; set; }
        public string CustEmail { get; set; }
        public DateTime CustDOB { get; set; }
        public bool Over18 { get; set; }
    }


}