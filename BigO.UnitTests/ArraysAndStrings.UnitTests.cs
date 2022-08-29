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
    }
}