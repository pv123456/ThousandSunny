using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Creates an instance of the staff class
            clsStaff AStaff = new clsStaff();
            //Tests to see if it exists
            Assert.IsNotNull(AStaff);
        }
    }
}
