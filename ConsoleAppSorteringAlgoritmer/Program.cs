using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleAppSorteringAlgoritmer
{
    public class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 3; i++)
            //{
            //    var watch = new Stopwatch();
            //    int[] inputArr = Utilities.genRanNums(1000);

            //    //Utilities.PrintArr(inputArr);
            //    watch.Start();
            //    SorteringAlgoritme.QuickSort(inputArr, 0, inputArr.Length -1);
            //    watch.Stop();
            //    //Utilities.PrintArr(inputArr);
            //    Console.WriteLine("time : " + watch.Elapsed.TotalSeconds.ToString("N6"));
            //}

            Console.WriteLine("10");
            runMulti(10);
            Console.WriteLine("100");
            runMulti(100);
            Console.WriteLine("1.000");
            runMulti(1000);
            Console.WriteLine("10.000");
            runMulti(10000);
            Console.WriteLine("100.000");
            runMulti(100000);
            Console.WriteLine("500.000");
            runMulti(500000);
            //Console.WriteLine("1.000.000");
            //runMulti(1000000);
            //Console.WriteLine("5.000.000");
            //runMulti(5000000);



            #region print
            //Console.WriteLine("Insertion sort:");
            //Utilities.PrintArr(inputArr);
            //SorteringAlgoritme.InsertionSort(inputArr);
            //Utilities.PrintArr(inputArr);

            //Console.WriteLine("Selection sort:");
            //Utilities.PrintArr(inputArr);
            //SorteringAlgoritme.InsertionSort(inputArr);
            //Utilities.PrintArr(inputArr);

            //Console.WriteLine("Merge sort:");
            //Utilities.PrintArr(inputArr);
            //SorteringAlgoritme.MergeSort(inputArr, 0, inputArr.Length - 1);
            //Utilities.PrintArr(inputArr);

            //Console.WriteLine("Quick sort:");
            //Utilities.PrintArr(inputArr);
            //SorteringAlgoritme.QuickSort(inputArr, 0, inputArr.Length - 1);
            //Utilities.PrintArr(inputArr);
            #endregion


            Console.ReadLine();
        }

        static void runMulti(int num)
        {
            for (int i = 0; i < 3; i++)
            {
                var watch = new Stopwatch();
                int[] inputArr = Utilities.genRanNums(num);

                //Utilities.PrintArr(inputArr);
                watch.Start();
                SorteringAlgoritme.InsertionSort(inputArr);
                watch.Stop();
                //Utilities.PrintArr(inputArr);
                Console.WriteLine("time : " + watch.Elapsed.TotalSeconds.ToString("N6"));
            }
        }
    }
}
