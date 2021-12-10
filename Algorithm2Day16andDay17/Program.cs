using System;


namespace Algorithm2Day16andDay17
{
    class Program
    {
            // Returns index of x if it is present in arr[],
            // else return -1
            static int binarySearch(String[] arr, String x)
            {
                int a = 0, r = arr.Length - 1;
            while (a <= r)
            {
                int m = a + (r - a) / 2;

                int result = x.CompareTo(arr[m]);

                // Check if x is present at middle
                    if (result == 0)                
                    {
                        return m;
                    }

                    else if (result > 0)
                    {
                        a = m + 1;
                    }

                    else
                    {
                        r = m - 1;
                    }
                }
            

                return -1;
            }
           
            public static void Main(String[] args)
            {
                String[] arr = { "ABC", "DEF", "GHI", "JKLM" };
                String x = "GHI";
                int result = binarySearch(arr, x);

                if (result == -1)
                    Console.WriteLine("Element not present");
                else
                    Console.WriteLine("Element found at "+ "index " + result);
            }



        }
    }

