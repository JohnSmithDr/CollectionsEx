using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fnio.Lib.CollectionsEx.UnitTest
{
    [TestClass]
    public class AddRangeTest
    {
        [TestMethod]
        public void TestAddRangeFromEnumerable()
        {
            var col = new LinkedList<int>();
            col.AddRange(new List<int> {0, 1, 2, 3});
            col.Should().HaveCount(4).And.Equal(0, 1, 2, 3);
        }

        [TestMethod]
        public void TestAddRangeFromParams()
        {
            var col = new LinkedList<int>();
            col.AddRange(0, 1, 2, 3);
            col.Should().HaveCount(4).And.Equal(0, 1, 2, 3);
        }
    }
}