using NUnit.Framework;

namespace DataStructures.Tests
{
    public class Tests
    {
        [Test]
        public void Add()
        {
            ArrayList expected = new ArrayList(new int[] { 5, 2 });
            ArrayList actual = new ArrayList();
            //actual.Add(5);
            actual.Add(2);
            actual.AddToFirst(5);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddFirst()
        {
            ArrayList expected = new ArrayList(new int[] { 5, 2, 8, 14, 0 });
            ArrayList actual = new ArrayList(new int[] { 2, 8, 14, 0 });
            //actual.Add(5);
            //actual.Add(2);
            actual.AddToFirst(5);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddByInd()
        {
            ArrayList expected = new ArrayList(new int[] { 5, 2, 8, 14, 0 });
            ArrayList actual = new ArrayList(new int[] { 5, 2, 14, 0 });
            //actual.Add(5);
            //actual.Add(2);
            actual.AddByIndex(8, 2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Delete()
        {
            ArrayList expected = new ArrayList(new int[] { 5, 2, 8, 14 });
            ArrayList actual = new ArrayList(new int[] { 5, 2, 8, 14, 0 });
            actual.DeleteLast();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Delete2()
        {
            ArrayList expected = new ArrayList(new int[] { 5, 2, 8, 14, 0 });
            ArrayList actual = new ArrayList(new int[] { 5, 2, 8, 14, 0 });
            actual.AddByIndex(7, 5);
            actual.DeleteLast();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DeleteFirst()
        {
            ArrayList expected = new ArrayList(new int[] { 5, 2, 8, 14 });
            ArrayList actual = new ArrayList(new int[] { 7, 5, 2, 8, 14 });
            actual.DeleteFirst();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DeleteInd()
        {
            ArrayList expected = new ArrayList(new int[] { 5, 2, 8, 14 });
            ArrayList actual = new ArrayList(new int[] { 5, 2, 9, 8, 14 });
            actual.DeleteIndex(2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReturnElement()
        {
            ArrayList arrayList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int expected = 2;
            int actual = arrayList.ReturnElement(1);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReturnIndex()
        {
            ArrayList arrayList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int expected = 4;
            int actual = arrayList.ReturnIndex(5);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReturnIndexNegative()
        {
            ArrayList arrayList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                int actual = arrayList.ReturnIndex(6);
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
            actual.ChangeElement(2, 8);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ChangeElementNegative()
        {
            ArrayList arrayList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            try
            {
                arrayList.ChangeElement(6, 0);
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
            actual.AddArray(new int[] { 0, 1, 2, 3, 4, 5 });
            Assert.AreEqual(expected, actual);
        }
    }
}