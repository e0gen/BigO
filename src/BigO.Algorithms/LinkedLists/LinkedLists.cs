using BigO.DataStructures;

namespace BigO.Algorithms.LinkedLists
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
        public static LinkedListNode<T>? FindNodeByIndexFromEndDouble<T>(this LinkedList<T> llist, int k)
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
        public static SingleLinkedListNode<T>? FindNodeByIndexFromEnd<T>(this SingleLinkedList<T> llist, int k)
        {
            //Assume list is single linked
            var i = 1;
            var result = llist.Head;
            var node = llist.Head;
            while (node is not null)
            {
                if (i > k)
                {
                    result = result?.Next;
                }

                node = node.Next;
                i++;
            }
            return result;
        }

        /// <summary>
        /// Time Complexity is O(N).
        /// </summary>
        public static void RemoveByIndex<T>(SingleLinkedList<T> llist, int k)
        {
            if (k == 1 || k == llist.Count)
                throw new ArgumentException("Support middle nodes only");

            var i = 1;
            var previous = llist.Head;
            var node = llist.Head;
            while (node is not null)
            {
                if (i == k)
                {
                    previous.Next = node.Next;
                    break;
                }

                if (i > 1)
                {
                    previous = previous?.Next;
                }
                node = node.Next;
                i++;
            }
        }
    }
}
