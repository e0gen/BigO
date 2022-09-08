namespace BigO.ArraysAndStrings
{
    public static class Strings
    {
        /// <summary>
        /// Time Complexity is O(1).
        /// </summary>
        public static bool HasUniqueChars(this string s)
        { 
            HashSet<char> chars = new();
            //O(n) but actually O(1) due to assumption unique char are fixed value
            for (int i = 0; i < s.Length; i++)
            {
                if (chars.Contains(s[i])) {
                    return false;
                }
                chars.Add(s[i]);
            }
            return true;
        }

        /// <summary>
        /// Time Complexity is O(N).
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


        /// <summary>
        /// Time Complexity is O(N).
        /// </summary>
        public static bool IsOneEditAwayFrom(this string a, string b)
        {
            if (Math.Abs(a.Length - b.Length) > 1)
                return false;
            
            int changes = 0;
            // A == B
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i])
                    {
                        if (++changes > 1)
                            return false;
                    }
                }
                return true;
            }
            // A > B => A < B
            if (a.Length - b.Length == 1)
            {
                (b, a) = (a, b);
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i + changes])
                {
                    if (++changes > 1)
                        return false;
                }
            }
            return true;
        }
    }
}
