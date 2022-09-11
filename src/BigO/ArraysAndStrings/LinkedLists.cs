namespace BigO.LinkedLists
{

    public static class LinkedLists
    {
        /// <summary>
        /// Time Complexity is O(N).
        /// </summary>
        public static void RemoveDups<T>(LinkedList<T> llist)
        {
            HashSet<T> uniques = new ();

            var node = llist.First;
            while (node is not null)
            {
                if(uniques.Contains(node.Value))
                {
                    var dup = node;
                    node = node.Next;
                    llist.Remove(dup); 
                    continue;
                } 

                uniques.Add(node.Value);
                node = node.Next;
            }
        }
    }
}
