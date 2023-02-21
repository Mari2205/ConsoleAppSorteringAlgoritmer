using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSorteringAlgoritmer
{
    public static class SorteringAlgoritme
    {
        public static int[] InsertionSort(int[] inputArr) {
            for (int i = 0; i < inputArr.Length; i++){
                int nextItem = inputArr[i];
                int j = i - 1;

                while (j >= 0 && inputArr[j] > nextItem)
                {
                    inputArr[j + 1] = inputArr[j];
                    j--;

                }
                j++;
                inputArr[j] = nextItem;
            }

            return inputArr;
        }
        
        public static int[] SelectionSort(int[] inputArr) {
            for (int i = 0; i < inputArr.Length; i++)
            {
                int minValueIndex = i;
                for (int j = 0; j < inputArr.Length; j++)
                {
                    if (inputArr[j] < inputArr[minValueIndex])
                    {
                        minValueIndex = j;
                    }
                }
                if (minValueIndex != i)
                {
                    //Utilities.Swap(inputArr, i, minValueIndex);
                    int temp = inputArr[i];
                    inputArr[i] = inputArr[minValueIndex];
                    inputArr[minValueIndex] = temp;
                }
            }

            
            return inputArr;


        }
       
        public static int[] MergeSort(int[] inputArr, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                int middleIndex = (startIndex + endIndex) / 2;

                MergeSort(inputArr, startIndex, middleIndex);
                MergeSort(inputArr, middleIndex + 1 , endIndex);

                Merge(inputArr, startIndex, middleIndex, endIndex);

            }
            return inputArr;
        }

        private static void Merge(int[] arr, int startIndex, int middleIndex, int endIndex)
        {
            int[] temp = new int[arr.Length];
            int i, midI, k;
            i = startIndex;
            midI = middleIndex + 1;
            k = startIndex;

            while (i <= middleIndex && midI <= endIndex)
            {
                if (arr[i] <= arr[midI])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[midI++];
                }
            }
            while (i <= middleIndex)
            {
                temp[k++] = arr[i++];
            }
            while (midI <= endIndex)
            {
                temp[k++] = arr[midI++];
            }
            for (i = startIndex; i <= endIndex; i++)
            {
                arr[i] = temp[i];
            }
        }
       
        public static int[] QuickSort(int[] arr, int left, int right) {
            //int i = left, j = right;
            //int tmp;
            //int pivot = inputArr[(left + right) / 2];

            //while (i <= j)
            //{
            //    while (inputArr[i] < pivot)
            //    {
            //        i++;
            //    }
            //    while (inputArr[j] > pivot)
            //    {
            //        j--;
            //    }
            //    if (i <= j)
            //    {
            //        tmp = inputArr[i];
            //        inputArr[i] = inputArr[j];
            //        inputArr[j] = tmp;
            //        //Utilities.Swap(inputArr, i, j);
            //        i++;
            //        j--;
            //    }
            //}

            //if (left < j)
            //{
            //    QuickSort(inputArr, left, j);
            //}
            //if (i > right)
            //{
            //    QuickSort(inputArr, i, right);
            //}

            int i = left, j = right;
            int tmp;
            int pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i] < pivot)
                    i++;
                while (arr[j] > pivot)
                    j--;
                if (i <= j)
                {
                    tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSort(arr, left, j);
            if (i < right)
                QuickSort(arr, i, right);

            return arr;
        }

    }
}
