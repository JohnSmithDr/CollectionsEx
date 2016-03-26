using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fnio.Lib.CollectionsEx.UnitTest
{
    [TestClass]
    public class ForEachTest
    {
        [TestMethod]
        public void TestIteration()
        {
            var col = new[] {"foo", "bar"};
            col.ForEach(x => { x.Should().NotBeNullOrEmpty(); });
        }

        [TestMethod]
        public void TestIterationWithIndex()
        {
            var col = new[] {0, 1, 2, 3, 4, 5};
            col.ForEach((x, i) => { x.Should().Be(i); });
        }

        [TestMethod]
        public void TestIterationOfDictionary()
        {
            var dict = new Dictionary<string, int>
            {
                {"foo", 1},
                {"bar", 2}
            };
            dict.ForEach((key, value) =>
            {
                key.Should().NotBeNullOrEmpty();
                value.Should().BeGreaterThan(0);
            });
        }
    }
}