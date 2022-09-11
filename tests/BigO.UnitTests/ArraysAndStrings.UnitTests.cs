namespace BigO.ArraysAndStrings.UnitTests
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
        public void URLify_UnescapedString_ReturnEscaped(string input, string expected)
        {
            //Arrange
            var inputChars = input.ToCharArray();

            //Act
            Arrays.URLify(ref inputChars);

            //Assert
            new string(inputChars).Should().Be(expected);
        }

        [Theory]
        [InlineData("Tact Coa")]
        public void HasPalindromePermutation_WhichHas_ReturnTrue(string input)
        {
            //Act
            var result = input.HasPalindromePermutation();

            //Assert
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("abcd efg")]
        public void HasPalindromePermutation_WhichHasNot_ReturnTrue(string input)
        {
            //Act
            var result = input.HasPalindromePermutation();

            //Assert
            result.Should().BeFalse();
        }

        [Theory]
        [InlineData("pale", "ple", true)]
        [InlineData("pales", "pale", true)]
        [InlineData("pale", "bale", true)]
        [InlineData("pale", "pal", true)]
        [InlineData("pele", "pal", false)]
        [InlineData("pale", "bake", false)]
        [InlineData("palepale", "bake", false)]
        [InlineData("pale", "bakebake", false)]
        public void IsOneEditAwayFrom_OnVariousInputs_ReturnExpectation(string first, string second, bool expected)
        {
            //Act
            var result = first.IsOneEditAwayFrom(second);

            //Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("aabcccccaaa", "a2b1c5a3")]
        [InlineData("aabbccddeeffgg", "aabbccddeeffgg")]
        [InlineData("aabbccddeeffggg", "a2b2c2d2e2f2g3")]
        public void Compress_TextString_ReturnCompressedOrSame(string input, string expected)
        {
            //Act
            var result = input.Compress();

            //Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("waterbottle", "erbottlewat", true)]
        [InlineData("waterbottle", "erbottlewatt", false)]
        public void IsRotationOf_OnVariousInputs_ReturnExpectation(string first, string second, bool expected)
        {
            //Act
            var result = first.IsRotationOf(second);

            //Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void RotateMatrix_OnMatrix_MatrixClockwiseRotated()
        {
            //Arrange
            var matrix = new[,] {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            var expected = new[,]{
                {13, 9, 5, 1},
                {14, 10, 6, 2},
                {15, 11, 7, 3},
                {16, 12, 8, 4}
            };

            //Act
            Arrays.RotateMatrix(ref matrix);

            //Assert
            matrix.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ZeroMatrix_OnMatrix_MatrixUpdated()
        {
            //Arrange
            var matrix = new[,] {
                { 1, 2, 3, 4 },
                { 5, 0, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 0 }
            };

            var expected = new[,]{
                {1, 0, 3, 0},
                {0, 0, 0, 0},
                {9, 0, 11, 0},
                {0, 0, 0, 0}
            };

            //Act
            Arrays.ZeroMatrix(ref matrix);

            //Assert
            matrix.Should().BeEquivalentTo(expected);
        }
    }
}