using Microsoft.VisualStudio.TestTools.UnitTesting;
using csc_455_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csc_455_1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void randomnumberTest()
        {
            var fun = new Program();
            var r = fun.randomnumber();
            Assert.IsTrue(r >= 1 && r <= 10);
            Assert.IsNotNull(r);
            Assert.IsFalse(r > 11);
        }
    }
}