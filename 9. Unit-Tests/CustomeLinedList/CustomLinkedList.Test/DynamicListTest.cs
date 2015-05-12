using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomLinkedList;

namespace CustomLinkedList.Test
{
    [TestClass]
    public class DynamicListTest
    {

        [TestInitialize]
        public void TestInitialize()
        {
        }

        DynamicList<int> list = new DynamicList<int>();
            

        [TestMethod]
        public void AddShouldAddToTheList()
        {
            
            list.Add(5);
            Assert.AreEqual(5, list[0], "The method Add doesnt return the right number.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAtShouldRemoveAtTheDesiredPosition()
        {
            list.Add(5);
            list.RemoveAt(0);
            Assert.IsNull(list[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveShouldFindAndRemoveAnElement()
        {
            list.Add(5);
            list.Add(3);
            list.Remove(3);
            Assert.IsNull(list[1]);
        }

        [TestMethod]
        public void IndexOfShouldSearchAndReturnAnElement()
        {
            list.Add(5);
            list.Add(3);
            Assert.AreEqual(1, list.IndexOf(3), "The index doesnt find the number.");
        }

        [TestMethod]
        public void ContainsShouldCheckIfGivenElementExists()
        {
            list.Add(5);
            list.Add(3);
            Assert.IsTrue(list.Contains(3), "Contains method doesnt not find the number.");
        }
    }
}
