using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.DLL;
using NUnit.Framework;

namespace DataStructures.Tests
{
    class DoubleLinkedListTest
    {
        [TestCase(new int[] {1, 2, 3, 4 }, 1, 2)]
        [TestCase(new int[] {1, 2, 3, 4, 5 }, 2, 3)]
        [TestCase(new int[] {1, 2, 3, 4, 5 }, 3, 4)]
        public void Get(int[] array, int index, int expected)
        {
            DoubleLinkedList ll = new DoubleLinkedList(array);
            int actual = ll[index];
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 5, new int[] { 5 })]
        [TestCase(new int[] { 7, 0 }, -1, new int[] { 7, 0, -1 })]
        [TestCase(new int[] { 4, 4, 4 }, 4, new int[] { 4, 4, 4, 4 })]
        [TestCase(new int[] { -8, -7, -6, -5, -4, -3, -2 }, 10, new int[] { -8, -7, -6, -5, -4, -3, -2, 10 })]
        [TestCase(new int[] { 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4 }, 5, new int[] { 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5 })]
        public void AddOneElement(int[] array, int value, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.Add(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { }, new int[] { 5, 4, 11 }, new int[] { 5, 4, 11 })]
        [TestCase(new int[] { 8, 8 }, new int[] { }, new int[] { 8, 8 })]
        [TestCase(new int[] { 10, 12, 18, 40 }, new int[] { 50, 88, 9, 104 }, new int[] { 10, 12, 18, 40, 50, 88, 9, 104 })]
        [TestCase(new int[] { 1 }, new int[] { 2, 2 }, new int[] { 1, 2, 2 })]
        [TestCase(new int[] { -10, -20, -30, -40, -50 }, new int[] { -60 }, new int[] { -10, -20, -30, -40, -50, -60 })]
        public void AddArray(int[] array, int[] addArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.Add(addArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 10, new int[] { 10 })]
        [TestCase(new int[] { 1, 1 }, -1, new int[] { -1, 1, 1 })]
        [TestCase(new int[] { 2, 4, 6, 8 }, 0, new int[] { 0, 2, 4, 6, 8 })]
        [TestCase(new int[] { -5, -5, -5, -5 }, -5, new int[] { -5, -5, -5, -5, -5 })]
        [TestCase(new int[] { 6, 9, 12, 15, 18, 21, 24, 27, 30 }, 3, new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 })]
        public void AddFirstOneElement(int[] array, int value, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.AddToFirst(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { }, new int[] { 5, 4, 11 }, new int[] { 5, 4, 11 })]
        [TestCase(new int[] { 8, 8 }, new int[] { }, new int[] { 8, 8 })]
        [TestCase(new int[] { 10, 12, 18, 40 }, new int[] { 50, 88, 9, 104 }, new int[] { 50, 88, 9, 104, 10, 12, 18, 40 })]
        [TestCase(new int[] { 1 }, new int[] { 2, 2 }, new int[] { 2, 2, 1 })]
        [TestCase(new int[] { -10, -20, -30, -40, -50 }, new int[] { -60 }, new int[] { -60, -10, -20, -30, -40, -50 })]
        public void AddToFirstArray(int[] array, int[] addArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.AddToFirst(addArray);
            Assert.AreEqual(expected, actual);
        }
    }
}
