namespace BigO.ArraysAndStrings
{
    public static class Arrays
    {
        /// <summary>
        /// Time Complexity is O(N).
        /// </summary>
        public static void URLify(ref char[] s)
        {
            //Memory O(N)
            var result = new char[s.Length];
            var shift = 0;

            //Time O(N)
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i - shift] == ' ')
                {
                    result[i] = '%';
                    result[i + 1] = '2';
                    result[i + 2] = '0';
                    i += 2;
                    shift += 2;
                    continue;
                }

                result[i] = s[i - shift];
            }
            s = result;
        }

        /// <summary>
        /// Time Complexity is O(N^2).
        /// </summary>
        public static void RotateMatrix(ref int[,] m)
        {

        }
    }
}
