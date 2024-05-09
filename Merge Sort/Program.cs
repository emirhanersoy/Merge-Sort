using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    public class Program
    {
        static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            int mid = array.Length / 2;
            int[] leftArray = new int[mid];
            int[] rightArray = new int[array.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                leftArray[i] = array[i];
            }

            for (int i = mid; i < array.Length; i++)
            {
                rightArray[i - mid] = array[i];
            }

            leftArray = MergeSort(leftArray);
            rightArray = MergeSort(rightArray);

            return Merge(leftArray, rightArray);
        }

        static int[] Merge(int[] leftArray, int[] rightArray)
        {
            int[] mergedArray = new int[leftArray.Length + rightArray.Length];
            int i = 0, j = 0, k = 0;

            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    mergedArray[k++] = leftArray[i++];
                }
                else
                {
                    mergedArray[k++] = rightArray[j++];
                }
            }

            while (i < leftArray.Length)
            {
                mergedArray[k++] = leftArray[i++];
            }

            while (j < rightArray.Length)
            {
                mergedArray[k++] = rightArray[j++];
            }

            return mergedArray;
        }
        static void Main(string[] args)
        {
           
                int[] array = { 8, 5, 2, 9, 7, 1, 6, 3 };
                Console.WriteLine("Sıralanmamış Dizi:");
                foreach(int i in array)
                {
                    Console.WriteLine(i);
                }

                array = MergeSort(array);

                Console.WriteLine("\nSıralanmış Dizi:");
                foreach (int i in array)
                {
                    Console.WriteLine(i);
                }

            Console.ReadKey();
        }

        

        }
    }

