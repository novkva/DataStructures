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
    }
}