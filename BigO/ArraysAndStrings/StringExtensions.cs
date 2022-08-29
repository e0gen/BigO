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

        /// <summary>
        /// Time Complexity is O(N). Space Complexity is O(1)
        /// </summary>
        public static bool IsPermutationOf(this string a, string b)
        {
            if (a.Length != b.Length) return false;

            int[] charsCount = new int[128]; // Unique chars assumption ASCII

            //O(N)
            for (int i = 0; i < a.Length; i++)
            {
                var val = a[i] - 'a';
                charsCount[val]++;
            }

            //O(N)
            for (int i = 0; i < b.Length; i++)
            {
                var val = b[i] - 'a';

                if (--charsCount[val] < 0)
                    return false;
            }
            return true;
        }
    }
}
