using NUnit.Framework;

namespace DataStructures.Tests
{
    public class Tests
    {
        [Test]
        public void Add()
        {
            ArrayList expected = new ArrayList(new int[] {5, 2});
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
            ArrayList actual = new ArrayList(new int[] {2, 8, 14, 0 });
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
            ArrayList actual = new ArrayList(new int[] {7, 5, 2, 8, 14});
            actual.DeleteFirst();
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void DeleteInd()
        {
            ArrayList expected = new ArrayList(new int[] { 5, 2, 8, 14 });
            ArrayList actual = new ArrayList(new int[] { 5,2, 9, 8, 14});
            actual.DeleteIndex(2);
            Assert.AreEqual(expected, actual);
        }
    }
}