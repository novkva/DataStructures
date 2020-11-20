using NUnit.Framework;
using System;

namespace DataStructures.Tests
{
    public class ArrayListTests
    {
        [TestCase(new int[] { }, 5, new int[] { 5 })]
        [TestCase(new int[] { 7, 0 }, -1, new int[] { 7, 0, -1 })]
        [TestCase(new int[] { 4, 4, 4 }, 4, new int[] { 4, 4, 4, 4 })]
        [TestCase(new int[] { -8, -7, -6, -5, -4, -3, -2 }, 10, new int[] { -8, -7, -6, -5, -4, -3, -2, 10 })]
        [TestCase(new int[] { 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4 }, 5, new int[] { 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5 })]
        public void AddOneElement(int[] array, int value, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.Add(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 10, new int[] { 10 })]
        [TestCase(new int[] { 1, 1 }, -1, new int[] { -1, 1, 1 })]
        [TestCase(new int[] { 2, 4, 6, 8 }, 0, new int[] { 0, 2, 4, 6, 8 })]
        [TestCase(new int[] { -5, -5, -5, -5 }, -5, new int[] { -5, -5, -5, -5, -5 })]
        [TestCase(new int[] { 6, 9, 12, 15, 18, 21, 24, 27, 30 }, 3, new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 })]
        public void AddFirstOneElement(int[] array, int value, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.AddToFirst(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 1, 0, new int[] { 1 })]
        [TestCase(new int[] { 4, 7, 11 }, 5, 2, new int[] { 4, 7, 5, 11 })]
        [TestCase(new int[] { 1, 3, 5 }, -1, 0, new int[] { -1, 1, 3, 5 })]
        [TestCase(new int[] { 10, 20, 30, 40, 50, 60 }, 70, 6, new int[] { 10, 20, 30, 40, 50, 60, 70 })]
        [TestCase(new int[] { 5, 7 }, 9, 2, new int[] { 5, 7, 9 })]
        public void AddByIndOneElement(int[] array, int value, int index, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.AddByIndex(value, index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 1, 1)]
        [TestCase(new int[] { 5, 3 }, 4, 8)]
        [TestCase(new int[] { 1, 2, 3 }, 4, 4)]
        [TestCase(new int[] { 8, 10, 15 }, 3, -1)]
        public void AddByIndOneElementNegative(int[] array, int value, int index)
        {
            ArrayList arrayList = new ArrayList(array);
            try
            {
                arrayList.AddByIndex(value, index);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] {1, 2, 3 }, new int[] {1, 2 })]
        [TestCase(new int[] {1 }, new int[] {})]
        [TestCase(new int[] {-5, -8, -5, -8, 5, 8, 5, 8}, new int[] { -5, -8, -5, -8, 5, 8, 5 })]
        [TestCase(new int[] {}, new int[] {})]
        public void DeleteOneElement(int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.DeleteLast();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] {1, 2, 3, 4 }, new int[] { 2, 3, 4 })]
        [TestCase(new int[] { 5}, new int[] { })]
        [TestCase(new int[] { -8, -7, -6, -5, -4, -5, -6, -7,-8}, new int[] { -7, -6, -5, -4, -5, -6, -7, -8 })]
        public void DeleteFirstOneElement(int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.DeleteFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1, 2 }, 0, new int[] { 2})]
        [TestCase(new int[] {1 }, 0, new int[] { })]
        [TestCase(new int[] {1, 2, 3, 4, 5, 6 }, 5, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] {8, 9, 10, 11, 12, 131,145 }, 3, new int[] { 8, 9, 10, 12, 131, 145 })]
        [TestCase(new int[] {5, 5, 5, 4, 4, 4, 4, 3, 3 , 3, 2, 2, 2}, 4, new int[] { 5, 5, 5, 4, 4, 4, 3, 3, 3, 2, 2, 2 })]
        public void DeleteIndexOneElement(int[] array, int index, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.DeleteByIndex(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 1)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { }, 5)]
        [TestCase(new int[] {1, 6, 7 }, 3)]
        [TestCase(new int[] {0, 4, 18 }, -1)]
        [TestCase(new int[] {99, 77, 55 }, 10)]
        public void DeleteIndexOneElementNegative(int[] array, int index)
        {
            ArrayList arrayList = new ArrayList(array);
            Assert.Throws<ArgumentOutOfRangeException> (() => arrayList.DeleteByIndex(index));
        }

        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] {1, 2 }, 2)]
        [TestCase(new int[] { 8}, 1)]
        [TestCase(new int[] { 7,7,7,7,7,77,7,7,7,7,7,7,7,7}, 14)]
        public void Length(int[] arrray, int expected)
        {
            ArrayList arrayList = new ArrayList(arrray);
            int actual = arrayList.Length;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1, 2,3 }, 1, 2)]
        [TestCase(new int[] {8 }, 0, 8)]
        [TestCase(new int[] {9, 7, 5, 4}, 3, 4)]
        [TestCase(new int[] {10, 20, 25, 41 }, 0, 10)]
        public void ReturnElement(int[] array, int index, int expected)
        {
            ArrayList arrayList = new ArrayList(array);
            int actual = arrayList[index];
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { }, 1)]
        [TestCase(new int[] { 8, 4, 9, 11}, 10)]
        [TestCase(new int[] { 4, -5, 6}, 3)]
        [TestCase(new int[] { 7, 8, 9}, -5)]
        public void ReturnElementNegative(int[] array, int index)
        {
            ArrayList arrayList = new ArrayList(array);
            //Assert.Throws<Exception>(() =>arrayList[index]);
            try
            {
                int actual = arrayList[index];
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1}, 1, 0)]
        [TestCase(new int[] { 1, 2, 3, 4}, 4, 3)]
        [TestCase(new int[] { 8, 8, 9, 9}, 9, 2)]
        [TestCase(new int[] { -8, 10, 14, 49, -7}, -7, 4)]
        public void ReturnIndex(int[] array, int value, int expected)
        {
            ArrayList arrayList = new ArrayList(array);
            int actual = arrayList.ReturnIndex(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] {4, 8 }, 0)]
        [TestCase(new int[] {1, 1, 1 }, -5)]
        public void ReturnIndexNegative(int[] array, int value)
        {
            ArrayList arrayList = new ArrayList(array);
            try
            {
                int actual = arrayList.ReturnIndex(value);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }



        [TestCase(new int[] {1, 2 }, 1, 3, new int[] {1, 3 })]
        [TestCase(new int[] {0 }, 0, 10, new int[] {10 })]
        [TestCase(new int[] {8, 9, 10, 74 }, 3, 11, new int[] {8, 9, 10, 11})]
        [TestCase(new int[] {5, 5, 5,  5, 5, 5, 4,  5, 5 }, 6, 5, new int[] { 5, 5, 5,5, 5, 5, 5, 5, 5 })]
        [TestCase(new int[] {-7, -41, -9, 8, 9 }, 0, 5, new int[] {5, -41, -9, 8, 9 })]
        public void ChangeElement(int[] array, int index, int value, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual[index] = value;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 0, 1)]
        [TestCase(new int[] {5, 7 }, 2, 6)]
        [TestCase(new int[] {10, 30, 50 }, -4, 70)]
        [TestCase(new int[] { }, 2, 10)]
        public void ChangeElementNegative(int[] array, int index, int value)
        {
            ArrayList arrayList = new ArrayList(array);
            try
            {
                arrayList[index] = value;
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] {1 }, new int[] { 1})]
        [TestCase(new int[] { 40, 50, 60, 80}, new int[] {80, 60, 50, 40 })]
        [TestCase(new int[] {95, 94, 93, 92, 91, 90, 89 }, new int[] {89, 90, 91, 92, 93, 94, 95 })]
        [TestCase(new int[] {-8, -8}, new int[] {-8, -8 })]
        public void Reverse(int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.Reverse();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {10 }, 10)]
        [TestCase(new int[] {0, 8, 15, 4 }, 15)]
        [TestCase(new int[] {90, -90, 1, 15, -12 }, 90)]
        [TestCase(new int[] {-40, -12, -1, -7, -100, -845 }, -1)]
        [TestCase(new int[] {1, 3, 5, 7, 9 , 11, 13 , 15 , 17, 19 }, 19)]
        public void MaxValue(int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);
            int actual = arrayList.MaxValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MaxValueNegative()
        {
            ArrayList arrayList = new ArrayList();
            try
            {
                arrayList.MaxValue();
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
            ArrayList arrayList = new ArrayList(array);
            int actual = arrayList.MinValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MinValueNegative()
        {
            ArrayList arrayList = new ArrayList();
            try
            {
                arrayList.MinValue();
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
            ArrayList arrayList = new ArrayList(array);
            int actual = arrayList.FindIndexOfMaxValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindIndexOfMaxValueNegative()
        {
            ArrayList arrayList = new ArrayList();
            try
            {
                arrayList.MinValue();
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
            ArrayList arrayList = new ArrayList(array);
            int actual = arrayList.FindIndexOfMinValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindIndexOfMinValueNegative()
        {
            ArrayList arrayList = new ArrayList();
            try
            {
                arrayList.MinValue();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] {10 }, 10 , new int[] { })]
        [TestCase(new int[] {4, 8 }, 8 , new int[] {4 })]
        [TestCase(new int[] {74, 81, 74 }, 74 , new int[] {81, 74 })]
        [TestCase(new int[] {9, -9, -9, -9, 9  }, -9 , new int[] { 9, -9, -9, 9 })]
        [TestCase(new int[] {8, 4, 7 }, 5 , new int[] {8, 4 ,7 })]
        [TestCase(new int[] {}, -1 , new int[] { })]
        public void DeleteFirstValue(int[] array, int value, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.DeleteFirstValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 9, new int[] { })]
        [TestCase(new int[] { 1, 2}, 2, new int[] {1 })]
        [TestCase(new int[] { 8, 8, 8, 4, 5, 7}, 8, new int[] { 4, 5, 7})]
        [TestCase(new int[] { 90, 40, 50, 40, 100, 40, 40 } , 40 , new int[] {90, 50, 100 })]
        [TestCase(new int[] { 66, 77, 88, 99, 111, 111, 111}, 111, new int[] { 66, 77, 88, 99 })]
        [TestCase(new int[] { 0, 5, 15, 25}, 0, new int[] { 5, 15, 25 })]
        public void DeleteAllValue(int[] array, int value, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.DeleteAllValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { }, new int[] { 5, 4, 11}, new int[] {5, 4, 11 })]
        [TestCase(new int[] { 8, 8}, new int[] { }, new int[] {8, 8 })]
        [TestCase(new int[] {10, 12, 18, 40 }, new int[] {50, 88, 9, 104 }, new int[] { 10, 12, 18, 40, 50, 88, 9, 104 })]
        [TestCase(new int[] {1}, new int[] {2, 2 }, new int[] { 1, 2, 2 })]
        [TestCase(new int[] {-10, -20, -30, -40, -50}, new int[] {-60 }, new int[] { -10, -20, -30, -40, -50, -60 })]
        public void AddArray(int[] array, int[] addArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.Add(addArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { }, new int[] { 5, 4, 11 }, new int[] { 5, 4, 11 })]
        [TestCase(new int[] { 8, 8 }, new int[] { }, new int[] { 8, 8 })]
        [TestCase(new int[] { 10, 12, 18, 40 }, new int[] { 50, 88, 9, 104 }, new int[] {  50, 88, 9, 104, 10, 12, 18, 40 })]
        [TestCase(new int[] { 1 }, new int[] { 2, 2 }, new int[] { 2, 2, 1 })]
        [TestCase(new int[] { -10, -20, -30, -40, -50 }, new int[] { -60 }, new int[] { -60, -10, -20, -30, -40, -50})]
        public void AddToFirstArray(int[] array, int[] addArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.AddToFirst(addArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 8, 8 }, new int[] { }, 1, new int[] { 8, 8 })]
       [TestCase(new int[] { 10, 12, 18, 40 }, new int[] { 50, 88, 9, 104 }, 3, new int[] {10, 12, 18, 50, 88, 9, 104, 40 })]
       [TestCase(new int[] { -10, -20, -30, -40, -50 }, new int[] { -60 }, 4, new int[] { -10, -20, -30, -40, -60, -50 })]
       [TestCase(new int[] {1 }, new int[] { 2, 2}, 0, new int[] {2, 2, 1 })]
        public void AddByIndexArray(int[] array, int[] addArray, int index, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.AddByIndex(addArray, index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, new int[] { }, 0)]
        [TestCase(new int[] { }, new int[] { 5, 4, 11 }, 0)]
        [TestCase(new int[] { }, new int[] { }, 1)]
        [TestCase(new int[] { 5, 3}, new int[] {1, 1, 11 }, 3)]
        [TestCase(new int[] { 8, 1}, new int[] {0, 7, 65 }, -3)]
        public void AddByIndexArrayNegative(int[] array, int[] addArray, int index)
        {
            ArrayList actual = new ArrayList(array);
            try
            {
                actual.AddByIndex(addArray, index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 8, 7 }, 2, new int[] { })]
        [TestCase(new int[] { 8, 7 }, 3, new int[] { })]
        [TestCase(new int[] { 8, 7, 6, 5, 4 }, 2, new int[] { 8, 7, 6})]
        [TestCase(new int[] { 8, 7, 6, 5, 4 }, 0, new int[] { 8, 7, 6, 5, 4})]
        [TestCase(new int[] { 8, 7, 6, 5, 4, 8, 7, 6, 5, 4, 8, 7, 6, 5, 4, 8, 7, 6, 5, 4, 8, 7, 6, 5, 4, 8, 7, 6, 5, 4 }, 29, new int[] { 8})]
        public void DeleteLastElements(int[] array, int amount, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.DeleteLast(amount);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 7, 4, 1}, 2, new int[] {1 })]
        [TestCase(new int[] { 8, 7 }, 2, new int[] { })]
        [TestCase(new int[] { 8, 7 }, 3, new int[] { })]
        [TestCase(new int[] { 8, 7, 6, 5, 4 }, 2, new int[] { 6, 5, 4 })]
        [TestCase(new int[] { 8, 7, 6, 5, 4 }, 0, new int[] { 8, 7, 6, 5, 4 })]
        [TestCase(new int[] { 8, 7, 6, 5, 4, 8, 7, 6, 5, 4, 8, 7, 6, 5, 4, 8, 7, 6, 5, 4, 8, 7, 6, 5, 4, 8, 7, 6, 5, 4 }, 29, new int[] { 4 })]
        public void DeleteFirstElements(int[] array, int amount, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.DeleteFirst(amount);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 7, 4, 1, 5, 0 }, 2, 3, new int[] { 7, 4 })]
        [TestCase(new int[] { 8, 7 }, 0, 2, new int[] { })]
        [TestCase(new int[] { 8, 7 }, 0, 3, new int[] { })]
        [TestCase(new int[] { 8, 7, 6, 5, 4 }, 1, 2, new int[] { 8, 5, 4 })]
        [TestCase(new int[] { 8, 7, 6, 5, 4 }, 4, 0, new int[] { 8, 7, 6, 5, 4 })]
        [TestCase(new int[] {7, 3, 1, 7, 3, 1, 7, 3, 1 }, 4, 10, new int[] { 7, 3, 1, 7 })]
        public void DeleteByIndexElements(int[] array, int index, int amount, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.DeleteByIndex(index, amount);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] {1, 8, 45, 74, -5, 89, 11 }, new int[] { -5, 1, 8, 11, 45, 74, 89})]
        [TestCase(new int[] { 0, 7, 8, 7, 0, 1}, new int[] { 0, 0, 1, 7, 7, 8})]
        [TestCase(new int[] { -88, -58, 41, 72, -5, 0, 1, 102, -9}, new int[] {-88, -58, -9, -5, 0, 1, 41, 72, 102 })]
        [TestCase(new int[] {0, 0, 0, 7, 9, 11, -8, 5, -41 }, new int[] { -41, -8, 0, 0, 0, 5, 7, 9, 11})]
        public void SortUp(int[] array, int[] expectedArray) 
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.SortUp();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1, 8, 45, 74, -5, 89, 11 }, new int[] { 89, 74, 45, 11, 8, 1, -5 })]
        [TestCase(new int[] { 0, 7, 8, 7, 0, 1 }, new int[] {8, 7, 7, 1, 0, 0 })]
        [TestCase(new int[] { -88, -58, 41, 72, -5, 0, 1, 102, -9 }, new int[] {102, 72, 41, 1, 0, -5, -9, -58, -88 })]
        [TestCase(new int[] { 0, 0, 0, 7, 9, 11, -8, 5, -41 }, new int[] {11, 9, 7, 5, 0, 0,0 , -8, -41 })]
        public void SortDown(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.SortDown();
            Assert.AreEqual(expected, actual);
        }
    }
}