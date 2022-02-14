
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Creates an instance of the Customer class
            clsCustomer ACustomer = new clsCustomer();
            //Tests to see if it exists
            Assert.IsNotNull(ACustomer);
        }
    }
}
