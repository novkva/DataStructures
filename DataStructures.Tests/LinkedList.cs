using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace DataStructures.Tests
{
    class Class1
    {
        [TestCase(new int[] { 1, 2 , 5}, 6, new int[] {1, 2, 5, 6})]
        [TestCase(new int[] { }, 6, new int[] { 6})]
        [TestCase(new int[] { 1}, 6, new int[] {1, 6})]
        [TestCase(new int[] { 1, 2 , 5, 4, 8 }, 6, new int[] {1, 2, 5, 4, 8,  6})]
        public void Add(int[] array, int value, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.Add(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 5 }, new int[] { 6 }, new int[] { 1, 2, 5, 6 })]
        [TestCase(new int[] { }, new int[] { 6 }, new int[] { 6 })]
        [TestCase(new int[] { 1 }, new int[] { 6, 7 }, new int[] { 1, 6 , 7})]
        [TestCase(new int[] { 1, 2, 5, 4, 8 }, new int[] { }, new int[] { 1, 2, 5, 4, 8 })]
        [TestCase(new int[] { 1, 2, 3}, new int[] {4, 5 }, new int[] { 1, 2,3, 4, 5})]
        [TestCase(new int[] { }, new int[] { 8, 9}, new int[] { 8, 9 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        public void AddArray(int[] array, int[] addArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.Add(addArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 5 }, 6, new int[] {6, 1, 2, 5 })]
        [TestCase(new int[] { }, 6, new int[] { 6 })]
        [TestCase(new int[] { 1 }, 6, new int[] { 6, 1 })]
        [TestCase(new int[] { 1, 2, 5, 4, 8 }, 10, new int[] { 10, 1, 2, 5, 4, 8 })]
        public void AddToFirst(int[] array, int value, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.AddToFirst(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 5 }, new int[] { 6 }, new int[] {6, 1, 2, 5 })]
        [TestCase(new int[] { }, new int[] { 6 }, new int[] { 6 })]
        [TestCase(new int[] { 1 }, new int[] { 6, 7 }, new int[] { 6, 7, 1 })]
        [TestCase(new int[] { 1, 2, 5, 4, 8 }, new int[] { }, new int[] { 1, 2, 5, 4, 8 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 4, 5, 1, 2, 3  })]
        [TestCase(new int[] { }, new int[] { 8, 9 }, new int[] { 8, 9 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        public void AddArrayToFirst(int[] array, int[] addArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.AddToFirst(addArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 20, 30 }, 15, 1, new int[] { 10, 15, 20, 30 })]
        [TestCase(new int[] { 44, 88, 99}, 77, 2, new int[] { 44, 88, 77, 99 })]
        [TestCase(new int[] { 12, 13, 15 }, 10, 0, new int[] { 10, 12, 13, 15 })]
        [TestCase(new int[] { 0, 1, 2, 3 }, 4, 4, new int[] { 0, 1, 2, 3, 4 })]
        public void AddByIndex(int[] array, int value, int index, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.AddByIndex(value, index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 20, 30, 40}, new int[] { 50 },4, new int[] { 10, 20, 30, 40, 50 })]
        [TestCase(new int[] { 10, 20, 30, 40}, new int[] { 50, 60 }, 4, new int[] { 10, 20, 30, 40, 50, 60 })]
        [TestCase(new int[] { 10, 20, 30, 40}, new int[] { 35}, 3, new int[] { 10, 20, 30,35, 40 })]
        [TestCase(new int[] { 10, 20, 30, 40}, new int[] { 35, 37 }, 3, new int[] { 10, 20, 30, 35, 37, 40 })]
        [TestCase(new int[] { }, new int[] { 6 },0, new int[] { 6 })]
        [TestCase(new int[] { }, new int[] { 1, 10 },0, new int[] { 1, 10 })]
        [TestCase(new int[] { }, new int[] {},0, new int[] { })]
        [TestCase(new int[] { 11, 12, 13, 14 }, new int[] { 10}, 0, new int[] { 10, 11, 12, 13, 14 })]
        [TestCase(new int[] { 11, 12, 13, 14 }, new int[] { 9, 10}, 0, new int[] {9, 10, 11, 12, 13, 14 })]
        [TestCase(new int[] { 11, 12, 13, 14 }, new int[] { }, 0, new int[] { 11, 12, 13, 14 })]
        [TestCase(new int[] { 10, 20, 30, 80, 90 }, new int[] { 40, 50 }, 3, new int[] { 10, 20, 30, 40, 50, 80, 90 })]
        [TestCase(new int[] { 10, 20, 30, 80, 90 }, new int[] { 50 }, 3, new int[] { 10, 20, 30, 50, 80, 90 })]
        [TestCase(new int[] { 10, 20, 30, 80, 90 }, new int[] { }, 3, new int[] { 10, 20, 30, 80, 90 })]
        public void AddArrayByIndex(int[] array, int[] addArray, int index, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.AddByIndex(addArray, index);
            Assert.AreEqual(expected, actual);
        }
    }
}
