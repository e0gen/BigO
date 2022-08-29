using BigO.ArraysAndStrings;
using FluentAssertions;

namespace BigO.UnitTests
{
    public class ArraysAndStringsUnitTests
    {
        [Theory]
        [InlineData("string")]
        [InlineData("abcdefg")]
        public void IsUnique_CharsAreUnique_ReturnTrue(string input)
        {
            //Act
            var result = input.IsUnique();

            //Assert
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("microsoft")]
        [InlineData("google")]
        public void IsUnique_CharsAreNotUnique_ReturnFalse(string input)
        {
            //Act
            var result = input.IsUnique();

            //Assert
            result.Should().BeFalse();
        }

        [Theory]
        [InlineData("microsoft", "softmicro")]
        [InlineData("google", "elgoog")]
        [InlineData("abcde", "edcba")]
        public void CheckPermutation_OneIsPermutationOfOther_ReturnTrue(string first, string second)
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
        public void CheckPermutation_OneIsNotPermutationOfOther_ReturnFalse(string first, string second)
        {
            //Act
            var result = first.IsPermutationOf(second);

            //Assert
            result.Should().BeFalse();
        }
    }
}