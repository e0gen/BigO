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

        /// <summary>
        /// Time Complexity is O(N).
        /// </summary>
        public static LinkedListNode<T> FindNodeByIndexFromEndDouble<T>(this LinkedList<T> llist, int k)
        {
            //Assume list is double linked
            var i = 1;
            var node = llist.Last;
            while (node is not null)
            {
                if(i == k)
                {
                    return node;
                }

                node = node.Previous;
                i++;
            }
            return node;
        }

        /// <summary>
        /// Time Complexity is O(N).
        /// </summary>
        public static LinkedListNode<T> FindNodeByIndexFromEndSingle<T>(this LinkedList<T> llist, int k)
        {
            //Assume list is single linked
            var i = 1;
            var result = llist.First;
            var node = llist.First;
            while (node is not null)
            {
                if (i > k)
                {
                    result = result.Next;
                }

                node = node.Next;
                i++;
            }
            return result;
        }
    }
}
