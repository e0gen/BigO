namespace BigO.LinkedLists.UnitTests
{
    public class LinkedListsUnitTests
    {
        private LinkedList<int> FromString(string sList)
        {
            return new LinkedList<int>(sList.Split(' ').Select(int.Parse));
        }

        [Theory]
        [InlineData("1 2 3 3 3 3 4 4 5 6 7 8 8", "1 2 3 4 5 6 7 8")]
        public void RemoveDups_OnLinkedList_MutatedList(string inputList, string expectedList)
        {
            //Arrange
            var lList = FromString(inputList);
            var expected = FromString(expectedList);

            //Act
            LinkedLists.RemoveDups(lList);

            //Assert
            lList.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData("10 22 30 40 50 60 70 80", 2, 70)]
        public void FindNodeByIndexFromEndDouble_OnLinkedList_ReturnNode(string inputList, int k, int expected)
        {
            //Arrange
            var lList = FromString(inputList);

            //Act
            var node = lList.FindNodeByIndexFromEndDouble(k);

            //Assert
            node.Value.Should().Be(expected);
        }

        [Theory]
        [InlineData("10 22 30 40 50 60 70 80", 2, 70)]
        public void FindNodeByIndexFromEndSingle_OnLinkedList_ReturnNode(string inputList, int k, int expected)
        {
            //Arrange
            var lList = FromString(inputList);

            //Act
            var node = lList.FindNodeByIndexFromEndSingle(k);

            //Assert
            node.Value.Should().Be(expected);
        }

        [Theory]
        [InlineData("1 2 3 4 5", 3, "1 2 4 5")]
        public void RemoveByIndexSingle_OnLinkedList_MutatedList(string inputList, int k, string expectedList)
        {
            //Arrange
            var lList = FromString(inputList);
            var expected = FromString(expectedList);

            //Act
            LinkedLists.RemoveByIndexSingle(lList, k);

            //Assert
            lList.Should().BeEquivalentTo(expected);
        }
    }
}