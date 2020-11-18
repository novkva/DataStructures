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

        [TestCase(new int[] { 10, 20, 30 }, 15, 5)]
        [TestCase(new int[] { 44, 88, 99 }, 77, 10)]
        [TestCase(new int[] { 12, 13, 15 }, 10, -1)]

        public void AddByIndexNegative(int[] array, int value, int index)
        {
            LinkedList actual = new LinkedList(array);
            try
            {
                actual.AddByIndex(value, index);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.Pass();
            }
            Assert.Fail();
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

        [TestCase(new int[] { 11, 12, 13, 14 }, new int[] { }, -1)]
        [TestCase(new int[] { 10, 20, 30, 80, 90 }, new int[] { 40, 50 }, 10)]
        [TestCase(new int[] { 10, 20, 30, 80, 90 }, new int[] { 50 }, 6)]
        public void AddArrayByIndexNegative(int[] array, int[] addArray, int index)
        {
            LinkedList actual = new LinkedList(array);
            try
            {
                actual.AddByIndex(addArray, index);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] {7, 8, 9, 10 }, new int[] {7, 8, 9 })]
        [TestCase(new int[] {10}, new int[] { })]
        [TestCase(new int[] { }, new int[] {})]
        [TestCase(new int[] {10, 20, 30, 40, 50 }, new int[] { 10, 20, 30, 40 })]
        public void DeleteLast(int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.DeleteLast();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 7, 8, 9, 10 }, 1, new int[] { 7, 8, 9 })]
        [TestCase(new int[] { 5, 5, 5, 5 }, 5, new int[] { })]
        [TestCase(new int[] { }, 2, new int[] { })]
        [TestCase(new int[] { 10, 20, 30, 40, 50 },3,  new int[] { 10, 20})]
        public void DeleteLastMany(int[] array, int amount, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.DeleteLast(amount);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 7, 8, 9, 10 }, new int[] { 8, 9, 10 })]
        [TestCase(new int[] { 10 }, new int[] { })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, new int[] { 20, 30, 40, 50 })]
        public void DeleteFirst(int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.DeleteFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 7, 8, 9, 10 }, 1,  new int[] { 8, 9, 10 })]
        [TestCase(new int[] { 10 }, 2, new int[] { })]
        [TestCase(new int[] { }, 3, new int[] { })]
        [TestCase(new int[] { 10, 20, 30, 40, 50 },2, new int[] { 30, 40, 50 })]
        public void DeleteFirstMany(int[] array, int amount, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.DeleteFirst(amount);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 6, 7, 8, 9}, 2, new int[] {5, 6, 8, 9 })]
        [TestCase(new int[] { 5, 6, 7, 8, 9}, 0, new int[] { 6, 7, 8, 9 })]
        [TestCase(new int[] { 5, 6, 7, 8, 9}, 4, new int[] { 5, 6, 7, 8 })]
        [TestCase(new int[] { 2}, 0, new int[] {})]
        public void DeleteByIndex(int[]array, int index, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.DeleteByIndex(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] {8, 10, 12 }, 3)]
        [TestCase(new int[] {11, 12, 13, 14 }, -1)]
        [TestCase(new int[] {11, 12, 13, 14 }, 10)]
        public void DeleteByIndexNegative(int[] array, int index)
        {
            
            LinkedList actual = new LinkedList(array);
            try
            {
                actual.DeleteByIndex(index);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 5, 6, 7, 8, 9 }, 2,2, new int[] { 5, 6, 9 })]
        [TestCase(new int[] { 5, 6, 7, 8, 9 }, 0,2, new int[] { 7, 8, 9 })]
        [TestCase(new int[] { 5, 6, 7, 8, 9 }, 4,2,  new int[] { 5, 6, 7, 8 })]
        [TestCase(new int[] { 10 }, 0, 2, new int[] { })]
        [TestCase(new int[] { 10, 20, 30 }, 1, 10, new int[] { 10})]
        [TestCase(new int[] { 10, 20, 30, 40 }, 0, 10, new int[] { })]
        public void DeleteByIndexMany(int[] array, int index, int size, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.DeleteByIndex(index, size);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 0, 2)]
        [TestCase(new int[] { 8, 10, 12 }, 3, 1)]
        [TestCase(new int[] { 11, 12, 13, 14 }, -1, 0)]
        [TestCase(new int[] { 11, 12, 13, 14 }, 10, 10)]
        public void DeleteByIndexManyNegative(int[] array, int index, int size)
        {

            LinkedList actual = new LinkedList(array);
            try
            {
                actual.DeleteByIndex(index, size);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] {10, 20, 30, 40, 50 }, 30, 2)]
        [TestCase(new int[] {10, 20, 30, 40, 50 }, 10, 0)]
        [TestCase(new int[] {10, 20, 30, 40, 50 }, 50, 4)]
        [TestCase(new int[] {10, 20, 30, 40, 10 }, 10, 0)]
        public void ReturnIndex(int[] array, int element, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.ReturnIndex(element);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 3)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 1)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 0)]
        public void ReturnIndexNegative(int[] array, int element)
        {
            LinkedList linkedList = new LinkedList(array);
            try
            {
                int actual = linkedList.ReturnIndex(element);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 10 }, 10)]
        [TestCase(new int[] { 0, 8, 15, 4 }, 15)]
        [TestCase(new int[] { 90, -90, 1, 15, -12 }, 90)]
        [TestCase(new int[] { -40, -12, -1, -7, -100, -845 }, -1)]
        [TestCase(new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }, 19)]
        public void MaxValue(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.MaxValue();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void MaxValueNegative()
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.MaxValue();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 10 }, 10)]
        [TestCase(new int[] { 0, 8, 15, 4 }, 0)]
        [TestCase(new int[] { 90, -90, 1, 15, -12 }, -90)]
        [TestCase(new int[] { -40, -12, -1, -7, -100, -845 }, -845)]
        [TestCase(new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }, 1)]
        public void MinValue(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.MinValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MinValueNegative()
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.MinValue();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 10 }, 0)]
        [TestCase(new int[] { 10, 8, 15, 40 }, 3)]
        [TestCase(new int[] { 90, -90, 1, 15, -12 }, 0)]
        [TestCase(new int[] { -40, -12, -1, -7, -100, -845 }, 2)]
        [TestCase(new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }, 9)]
        public void FindIndexOfMaxValue(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.FindIndexOfMaxValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindIndexOfMaxValueNegative()
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.MinValue();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 10 }, 0)]
        [TestCase(new int[] { 0, 8, 15, -4 }, 3)]
        [TestCase(new int[] { 90, -90, 1, 15, -12 }, 1)]
        [TestCase(new int[] { -40, -12, -1, -7, -100, -845 }, 5)]
        [TestCase(new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }, 0)]
        public void FindIndexOfMinValue(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.FindIndexOfMinValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindIndexOfMinValueNegative()
        {
            LinkedList linkedList = new LinkedList();
            try
            {
                linkedList.MinValue();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 10 }, 10, new int[] { })]
        [TestCase(new int[] { 4, 8 }, 8, new int[] { 4 })]
        [TestCase(new int[] { 74, 81, 74 }, 74, new int[] { 81, 74 })]
        [TestCase(new int[] { 9, -9, -9, -9, 9 }, -9, new int[] { 9, -9, -9, 9 })]
        [TestCase(new int[] { 8, 4, 7 }, 5, new int[] { 8, 4, 7 })]
        [TestCase(new int[] { }, -1, new int[] { })]
        public void DeleteFirstValue(int[] array, int value, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.DeleteFirstValue(value);
            Assert.AreEqual(expected, actual);
        }
    }
}
