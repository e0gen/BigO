namespace BigO.ArraysAndStrings
{
    public static class StringExtensions
    {
        /// <summary>
        /// Time Complexity is O(N)
        /// </summary>
        public static bool IsUnique(this string s)
        { 
            HashSet<char> chars = new();
            //O(N)
            for (int i = 0; i < s.Length; i++)
            {
                //O(1)
                chars.Add(s[i]);
            }
            //O(1)
            return chars.Count == s.Length;
        }
    }
}
