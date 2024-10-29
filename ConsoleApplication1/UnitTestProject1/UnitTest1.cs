using System;
using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class RetailUserTests
        {
            [TestMethod]
            public void TestClickOnProductImage_DisplaysErrorMessage()
            {
                
                // Arrange
                string expectedMessage = "We cannot find the page you're looking for.";

                // Act
                string actualMessage = Program.ClickOnProductImage();

                // Assert
                Assert.AreEqual(expectedMessage, actualMessage);
            }
        }
    }
}



