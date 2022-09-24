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
        public void RemoveDups_OnLinkedList_RemoveDuplications(string inputList, string expectedList)
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
        public void FindNodeByIndexFromEnd_OnLinkedList_ReturnNode(string inputList, int k, int expectedNode)
        {
            //Arrange
            var lList = FromString(inputList);

            //Act
            var node = lList.FindNodeByIndexFromEnd(k);

            //Assert
            node.Should().Be(expectedNode);
        }
    }
}