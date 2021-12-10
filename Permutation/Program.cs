using System;

namespace Permutation
{
    class Program
    {
        private static void permute(String str,int a, int r)
        {
            if (a == r)
                Console.WriteLine(str);
            else
            {
                for (int i = a; i <= r; i++)
                {
                    str = swap(str, a, i);
                    permute(str, a + 1, r);
                    str = swap(str, a, i);
                }
            }
        }

        public static String swap(String a,int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Permutations Of string are: \n");

            String str = "ABC";
            int n = str.Length;
            permute(str, 0, n - 1);
        }
    }
}