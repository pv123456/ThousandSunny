using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            //will create an instance of class i want
            clsSupplier AnSupplier = new clsSupplier();
            //Will see the class i made exist or not
                Assert.IsNotNull(AnSupplier);
        }
    }
}
