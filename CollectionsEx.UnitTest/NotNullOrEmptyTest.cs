using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fnio.Lib.CollectionsEx.UnitTest
{
    [TestClass]
    public class NotNullOrEmptyTest
    {
        [TestMethod]
        public void TestNotNull()
        {
            int[] arr = null;
            arr.NotNullOrEmpty().Should().BeFalse();

            arr = new[] {0, 1, 2, 3};
            arr.NotNullOrEmpty().Should().BeTrue();
        }

        [TestMethod]
        public void TestNotEmpty()
        {
            var list = new List<int>();
            list.NotNullOrEmpty().Should().BeFalse();

            list.AddRange(new[] {0, 1, 2, 3});
            list.NotNullOrEmpty().Should().BeTrue();
        }
    }
}