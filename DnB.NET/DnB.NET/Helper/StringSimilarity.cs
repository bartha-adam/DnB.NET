using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnB.NET.Helper
{
    public class StringSimilarity
    {
        public static float Similarity(String string1, String string2)
        {
            float dis = ComputeCost(string1, string2);
            float maxLen = string1.Length;
            if (maxLen < (float)string2.Length)
                maxLen = string2.Length;

            float minLen = string1.Length;
            if (minLen > (float)string2.Length)
                minLen = string2.Length;

            if (maxLen == 0.0F)
                return 1.0F;
            else
            {
                //return maxLen - dis;
                return 1.0F - dis/maxLen ;
                //return (float) Math.Round(1.0F - dis/maxLen, 1) * 10 ;
            }
        }

        private static int ComputeCost(string inputText, string against)
        {
            int n = inputText.Length;
            int m = against.Length;
            int[,] distance = new int[n + 1, m + 1]; // matrix
            int cost = 0;
            if (n == 0) return m;
            if (m == 0) return n;
            //init1
            for (int i = 0; i <= n; distance[i, 0] = i++) ;
            for (int j = 0; j <= m; distance[0, j] = j++) ;
            //find min distance
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    cost = (against.Substring(j - 1, 1) == inputText.Substring(i - 1, 1) ? 0 : 1);
                    distance[i, j] = Min3(distance[i - 1, j] + 1, distance[i, j - 1] + 1, distance[i - 1, j - 1] + cost);
                }
            }
            return distance[n, m];
        }

        private static int Min3(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
    }
}
