using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace StringComparison
{
    public class StringComparerTests
    {
        [Fact]
        public void GetCommonCharacters_FirstInputNull_ThrowsArgumentNullException()
        {
            var secondInput = "roses";
            Assert.Throws<ArgumentNullException>(() => StringComparer.GetCommonCharacters(null, secondInput));
        }

        [Fact]
        public void GetCommonCharacters_SecondInputNull_ThrowsArgumentNullException()
        {
            var firstInput = "roses";
            Assert.Throws<ArgumentNullException>(() => StringComparer.GetCommonCharacters(firstInput, null));
        }

        [Theory]
        [InlineData("hello", "there", new[] { 'h', 'e' })]
        [InlineData("hello", "dolly", new[] { 'o', 'l' })]
        [InlineData("hello", "", new char[] { })]
        [InlineData("", "hello", new char[] { })]
        [InlineData("1234", "4321", new char[] { '1','4','3','2'})]
        public void GetCommonCharacters_ValidStrings_ReturnListOfCommonCharacters(string firstString, string secondString, IEnumerable<char> expected)
        {
            var result = StringComparer.GetCommonCharacters(firstString, secondString);

            foreach(var element in expected)
            {
                Assert.True(result.Count(c => c == element) == 1);
            }

            foreach (var element in result)
            {
                Assert.True(expected.Count(c => c == element) == 1);
            }
        }
    }
}
