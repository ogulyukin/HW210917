using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_push_result_size_inreased()
        {
            // Arrange
            int value = 10;
            MyQueue<int> test = new();
            int size = test.Count();
            int expectedSize = size + 1;
            //Act
            test.Push(value);
            int actualSize = test.Count();
            //Assert
            Assert.AreEqual(expectedSize, actualSize);
        }

        [TestMethod]
        public void Test_pop_result_size_decresed()
        {
            // Arrange
            int value = 10;
            MyQueue<int> test = new();
            test.Push(value);
            int size = test.Count();
            int expectedSize = size - 1;
            //Act
            test.Pop();
            int actualSize = test.Count();
            //Assert
            Assert.AreEqual(expectedSize, actualSize);
        }

        [TestMethod]
        //[ExpectedException(Exception, "Error: Queue is empty.Nothing to Pop")]
        public void Test_pop_with_zero_size()
        {
            // Arrange
            MyQueue<int> test = new();
            int size = test.Count();
            int expectedSize = size - 1;
            //Act
            test.Pop();
            int actualSize = test.Count();
            //Assert
            Assert.AreEqual(expectedSize, actualSize);
        }
    }
}
