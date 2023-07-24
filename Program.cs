using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment_14
{
    internal class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;

                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers");
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("Numbers are :");
            Print(num);

            Console.WriteLine("Print Array without Sort");
            Print(num);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            BubbleSort(num);
            stopwatch.Stop();
            Console.WriteLine("print Array after bubble sort");
            Print(num);
            Console.WriteLine($" arraysize is {num.Length} Time Taken {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
            Console.ReadKey();

        }
    }
}
