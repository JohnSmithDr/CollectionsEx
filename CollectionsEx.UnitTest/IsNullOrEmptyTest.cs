using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fnio.Lib.CollectionsEx.UnitTest
{
    [TestClass]
    public class IsNullOrEmptyTest
    {
        [TestMethod]
        public void TestNull()
        {
            int[] arr = null;
            arr.IsNullOrEmpty().Should().BeTrue();

            arr = new[] {0, 1, 2, 3};
            arr.IsNullOrEmpty().Should().BeFalse();
        }

        [TestMethod]
        public void TestEmpty()
        {
            var list = new List<int>();
            list.IsNullOrEmpty().Should().BeTrue();

            list.Add(1);
            list.IsNullOrEmpty().Should().BeFalse();
        }
    }
}