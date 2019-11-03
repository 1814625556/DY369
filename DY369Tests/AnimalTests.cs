using Microsoft.VisualStudio.TestTools.UnitTesting;
using DY369;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY369.Tests
{
    [TestClass()]
    public class AnimalTests
    {
        [TestMethod()]
        public void RunTest()
        {
            Assert.AreEqual(false,new Animal().Run());
        }
    }
}