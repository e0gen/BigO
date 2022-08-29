using BigO.ArraysAndStrings;
using FluentAssertions;

namespace BigO.UnitTests
{
    public class ArraysAndStringsUnitTests
    {
        [Theory]
        [InlineData("string")]
        [InlineData("abcdefg")]
        public void HasUniqueChars_CharsAreUnique_ReturnTrue(string input)
        {
            //Act
            var result = input.HasUniqueChars();

            //Assert
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("microsoft")]
        [InlineData("google")]
        public void HasUniqueChars_CharsAreNotUnique_ReturnFalse(string input)
        {
            //Act
            var result = input.HasUniqueChars();

            //Assert
            result.Should().BeFalse();
        }

        [Theory]
        [InlineData("microsoft", "softmicro")]
        [InlineData("google", "elgoog")]
        [InlineData("abcde", "edcba")]
        public void IsPermutationOf_Permutation_ReturnTrue(string first, string second)
        {
            //Act
            var result = first.IsPermutationOf(second);

            //Assert
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("microsoft", "google")]
        [InlineData("tessst", "teeest")]
        [InlineData("abcde", "abcdf")]
        public void IsPermutationOf_NonPermutation_ReturnFalse(string first, string second)
        {
            //Act
            var result = first.IsPermutationOf(second);

            //Assert
            result.Should().BeFalse();
        }

        [Theory]
        [InlineData("Mr John Smith    ", "Mr%20John%20Smith")]
        [InlineData("Hello World  ", "Hello%20World")]
        public void URLify_SpecialString_ReturnEscaped(string input, string expected)
        {
            //Act
            var result = input.URLify();

            //Assert
            result.Should().Be(expected);
        }
    }
}