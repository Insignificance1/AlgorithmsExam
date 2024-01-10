using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgExam
{
    public class InsetionSort2
    {
        public static void Start(int size)
        {
            int[] array = GenerateRandomArray(size);
            Console.WriteLine("| Insertion Sort |");
            Console.WriteLine("Исходный массив: ");
            Print(array);
            Sort(array);
            Console.WriteLine("Отсортированный массив: ");
            Print(array);
        }
        public static int[] GenerateRandomArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++) { array[i] = random.Next(100); }
            return array;
        }
        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int current = array[i];
                int prev = i - 1;
                while(prev >= 0 && current < array[prev])
                {
                    array[prev + 1] = array[prev];
                    array[prev] = current;
                    prev--;
                }
            }
        }
        public static void Print(int[] array)
        {
            Console.Write("[ ");
            foreach (int item in array) Console.Write(item + " ");
            Console.Write("]\n\n");
        }
    }
}
