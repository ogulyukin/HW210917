using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_push_serult_size_inreased()
        {
            // Arrange
            int value = 10;
            int size = MyQueue.count();
            int expectedSize = size++;
            //Act
            MyQueue.push(10);
            int actualSize = MyQueue.count();
            //Assert
            Assert.AreEqual(expectedSize, actualSize);
        }
    }
}
