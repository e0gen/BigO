﻿namespace BigO.Algorithms.ArraysAndStrings
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
        public static void RotateMatrix<T>(ref T[,] m)
        {
            int n = (int)Math.Sqrt(m.Length);
            for (int depth = 0; depth < n / 2; depth++)
            {
                int first = depth;
                int last = n - 1 - depth;
                for (int i = first; i < last; i++)
                {
                    int offset = i - first;
                    
                    T tmp = m[first, i]; 
                    m[first,i] = m[last - offset, first]; // left->top
                    m[last - offset,first] = m[last, last - offset]; // bottom -> left
                    m[last, last - offset] = m[i,last]; // right -> bottom
                    m[i,last] = tmp; // top -> right
                }
            }
        }

        /// <summary>
        /// Time Complexity is O(N^2).
        /// </summary>
        public static void ZeroMatrix(ref int[,] m)
        {
            int n = (int)Math.Sqrt(m.Length);

            for (int i = 0; i < n; i++)
            {
                if (m[i, 0] == 0)
                    continue;

                for (int j = 0; j < n; j++)
                {
                    if (m[0, j] == 0)
                        continue;

                    if(m[i,j] == 0)
                    {
                        m[0, j] = 0;
                        m[i, 0] = 0;
                        break;
                    }
                   
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (m[i, 0] == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        m[i, j] = 0;
                    }
                }
            }

            for (int j = 0; j < n; j++)
            {
                if (m[0, j] == 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        m[i, j] = 0;
                    }
                }
            }
        }
    }
}
