using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationApp
{
    internal class BubbleSort
    {
        public int[] BubbleSortImp(int[] array)
        {
            int countSwap = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];

                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }

                    countSwap++;
                }
            }

            Console.WriteLine($"Кол-во операций = {countSwap}");

            return array;
        }
    }

    public static class BubbleSortMain
    {
        public static void RunBubbleSortImplementation()
        {
            BubbleSort bubbleSort = new BubbleSort();

            int[] array = new[] { 5, 1, 2, 0, 6, 4 };
            
            int[] sortedArray = bubbleSort.BubbleSortImp(array);

            foreach (var item in sortedArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
