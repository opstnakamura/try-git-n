using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppForAWS.Controllers;
using System.Web;

namespace Test.WebAppForAWS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var valuesController = new ValuesController();

            var result = valuesController.Get();


            Assert.IsInstanceOfType(result, typeof(IEnumerable<string>));

            var resulyArray = result.ToArray();

            Assert.AreEqual("value1", resulyArray[0]);
            Assert.AreEqual("value2", resulyArray[1]);
            
        }

        [TestMethod]
        public void TestMethod2()
        {

            var valuesController = new ValuesController();

            var result = valuesController.Get(1);

            Assert.IsInstanceOfType(result, typeof(IEnumerable<string>));

            Assert.IsInstanceOfType(result, typeof(string));
            Assert.AreEqual("value", result);


        }
    }
}
