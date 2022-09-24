using BigO.DataStructures;

namespace BigO.Algorithms.LinkedLists.UnitTests
{
    public class LinkedListsUnitTests
    {
        private static LinkedList<int> ParseToDoubleLL(string sList)
        {
            return new LinkedList<int>(sList.Split(' ').Select(int.Parse));
        }

        private static SingleLinkedList<int> ParseToSingleLL(string sList)
        {
            return new SingleLinkedList<int>(sList.Split(' ').Select(int.Parse));
        }

        [Theory]
        [InlineData("1 2 3 3 3 3 4 4 5 6 7 8 8", "1 2 3 4 5 6 7 8")]
        public void RemoveDups_OnDoubleLinkedList_MutateList(string inputList, string expectedList)
        {
            //Arrange
            var lList = ParseToDoubleLL(inputList);
            var expected = ParseToDoubleLL(expectedList);

            //Act
            LinkedLists.RemoveDups(lList);

            //Assert
            lList.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData("10 22 30 40 50 60 70 80", 2, 70)]
        public void FindNodeByIndexFromEnd_OnDoubleLinkedList_ReturnNode(string inputList, int k, int expected)
        {
            //Arrange
            var lList = ParseToDoubleLL(inputList);

            //Act
            var node = lList.FindNodeByIndexFromEndDouble(k);

            //Assert
            node?.Value.Should().Be(expected);
        }

        [Theory]
        [InlineData("10 22 30 40 50 60 70 80", 2, 70)]
        public void FindNodeByIndexFromEnd_OnSingleLinkedList_ReturnNode(string inputList, int k, int expected)
        {
            //Arrange
            var lList = ParseToSingleLL(inputList);

            //Act
            var node = lList.FindNodeByIndexFromEnd(k);

            //Assert
            node?.Value.Should().Be(expected);
        }

        [Theory]
        [InlineData("1 2 3 4 5", 3, "1 2 4 5")]
        public void RemoveByIndex_OnSingleLinkedList_MutateList(string inputList, int k, string expectedList)
        {
            //Arrange
            var lList = ParseToSingleLL(inputList);
            var expected = ParseToSingleLL(expectedList);

            //Act
            LinkedLists.RemoveByIndex(lList, k);

            //Assert
            lList.Should().BeEquivalentTo(expected);
        }
    }
}