namespace BigO.LinkedLists.UnitTests
{
    public class LinkedListsUnitTests
    {
        [Fact]
        public void RemoveDups_OnLinkedList_RemoveDuplications()
        {
            //Arrange
            var llist = new LinkedList<int>(new[] { 1, 2, 3, 3, 3, 5, 3 });

            var expected = new LinkedList<int>(new[] { 1, 2, 3, 5 });

            //Act
            llist.RemoveDups();

            //Assert
            llist.Should().BeEquivalentTo(expected);
        }
    }
}