using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interface.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        //MethodName_Condition_Expectation
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor();
        }
    }
}
