namespace BigO.LinkedLists.UnitTests
{
    public class LinkedListsUnitTests
    {
        [Fact]
        public void RemoveDups_OnLinkedList_RemoveDuplications()
        {
            //Arrange
            var llist = new LinkedList<int>(new[] { 1, 2, 3, 3, 3, 5, 3, 9 });

            var expected = new LinkedList<int>(new[] { 1, 2, 3, 5, 9 });

            //Act
            LinkedLists.RemoveDups(llist);

            //Assert
            llist.Should().BeEquivalentTo(expected);
        }
    }
}