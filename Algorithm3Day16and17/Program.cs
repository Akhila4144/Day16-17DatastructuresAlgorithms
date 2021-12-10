using System;

namespace Algorithm3Day16and17
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] arr = { "ABC", "DEF", "GHI" };
            int n = arr.Length;
            for (int i = 1; i <= n; ++i)
            {
                String item = arr[i];
                int j = i - 1;

                while (j >= 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = item;
            }
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine(arr[i] + " ");
                Console.WriteLine("\n");


            }

        }
    }
}

           
            
    

