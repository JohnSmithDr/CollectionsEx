using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Fnio.Lib.CollectionsEx.UnitTest
{
    [TestClass]
    public class AddToTest
    {
        [TestMethod]
        public void TestAddTo()
        {
            var list = new List<int>();
            1.AddTo(list);
            2.AddTo(list);
            list.Should().HaveCount(2).And.Equal(1, 2);
        }

        [TestMethod]
        public void TestAddToWithConvertion()
        {
            Func<int, string> convert = i => i.ToString();
            var list = new List<string>();
            1.AddTo(list, convert);
            2.AddTo(list, convert);
            list.Should().HaveCount(2).And.Equal("1", "2");
        }
    }
}
