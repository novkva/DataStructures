using NUnit.Framework;
using System;

namespace DataStructures.Tests
{
    public class Tests
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
            actual.DeleteIndex(index);
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
            Assert.Throws<Exception>(() => arrayList.DeleteIndex(index));
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

        [Test]
        public void ChangeElement()
        {
            ArrayList expected = new ArrayList(new int[] { 5, 2, 8, 14, 7 });
            ArrayList actual = new ArrayList(new int[] { 5, 2, 9, 14, 7 });
            actual[2] = 8;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ChangeElementNegative()
        {
            ArrayList arrayList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                arrayList[5] = 1;
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Reverse()
        {
            ArrayList expected = new ArrayList(new int[] { 5, 2, 8, 14, 7, 6 });
            ArrayList actual = new ArrayList(new int[] { 6, 7, 14, 8, 2, 5 });
            actual.Reverse();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MaxValue()
        {
            int expected = -2;
            ArrayList arrayList = new ArrayList(new int[] { -6, -7, -14, -8, -2, -5 });
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

        [Test]
        public void MinValue()
        {
            int expected = 1;
            ArrayList arrayList = new ArrayList(new int[] { 8, 1 });
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

        [Test]
        public void FindIndexOfMaxValue()
        {
            int expected = 0;
            ArrayList arrayList = new ArrayList(new int[] { 8, 1 });
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

        [Test]
        public void FindIndexOfMinValue()
        {
            int expected = 2;
            ArrayList arrayList = new ArrayList(new int[] { 8, 1, -7, 4 });
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

        [Test]
        public void DeleteFirstValue()
        {
            ArrayList expected = new ArrayList(new int[] { 5, 2, 14, 7, 6, 8 });
            ArrayList actual = new ArrayList(new int[] { 5, 2, 8, 14, 7, 6, 8 });
            actual.DeleteFirstValue(8);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DeleteAllValue()
        {
            ArrayList expected = new ArrayList(new int[] { 5, 2, 14, 7, 6 });
            ArrayList actual = new ArrayList(new int[] {8, 5, 2, 8, 8, 14, 7, 6, 8 });
            actual.DeleteAllValue(8);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddArray()
        {
            ArrayList expected = new ArrayList(new int[] { 5, 2, 14, 7, 6, 0, 1, 2, 3, 4, 5 });
            ArrayList actual = new ArrayList(new int[] { 5, 2, 14, 7, 6 });
            actual.Add(new int[] { 0, 1, 2, 3, 4, 5 });
            Assert.AreEqual(expected, actual);
        }
    }
}