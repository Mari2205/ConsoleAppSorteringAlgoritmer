using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSorteringAlgoritmer
{
    public static class Utilities
    {
        public static void PrintArr(int[] inputArr){
            foreach (var item in inputArr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public static int[] genRanNums(int numCount)
        {
            Random ran = new Random();
            int[] arr = new int[numCount];

            for (int i = 0; i < numCount; i++)
            {
                int ranNum = ran.Next(1, 1000000);
                //int ranNum = ran.Next(1, 100);// testering
                arr[i] = ranNum;
            }
            return arr;
        }

        public static void Swap(int[] arr, int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }

    }
}
