namespace BigO.LinkedLists
{

    public static class LinkedLists
    {
        /// <summary>
        /// Time Complexity is O(N).
        /// </summary>
        public static LinkedList<T> RemoveDups<T>(this LinkedList<T> llist)
        {
            HashSet<T> uniques = new ();
            LinkedList<T> resultList = new ();

            var currentNode = llist.First;

            while (currentNode.Next is not null)
            {
                if(!uniques.TryGetValue(currentNode.Value, out _))
                {
                    uniques.Add(currentNode.Value);
                    resultList.AddLast(currentNode.Value);
                }

                currentNode = currentNode.Next;

            }

            return resultList;
        }
    }
}
