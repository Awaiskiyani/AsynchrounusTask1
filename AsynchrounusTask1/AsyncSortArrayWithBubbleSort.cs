using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchrounusTask1
{
    internal class AsyncSortArrayWithBubbleSort
    {
        public static async Task<Array> SortedAsyncArray()
        {

            var array1 = await GenerateArrayAsync();
            Console.WriteLine("Before sorting");

            foreach (var item in array1)
            {
                Console.Write(item+",");
            }

            Console.WriteLine("After Sorting");

            await Task.Run(() =>
            {
                for (int i = 0; i < array1.Length - 1; i++)
                {
                    for (int j = 0; j < array1.Length - 1; j++)
                    {
                        if (array1[j] > array1[j + 1])
                        {
                            var temp = array1[j];
                            array1[j] = array1[j + 1];
                            array1[j + 1] = temp;

                        }
                    }
                }
            });

          
            //foreach (var item in array1)
            //{
            //    Console.WriteLine(item);
            //}
            return array1;
           
        }

        public static async Task<int[]> GenerateArrayAsync()
        {
            int[] array = new int[30];
            Random random = new Random();
           await Task.Run(() =>
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    array[i] = random.Next(0, 50) + i;
                }
            });


            return array;
        }

        public static async Task StopwatchBubbleSortASynchronize()
        {
            //A: Setup and stuff you don't want timed
            var timer = new Stopwatch();
            timer.Start();

            var numberArray =await AsyncSortArrayWithBubbleSort.SortedAsyncArray();

            await Task.Run(() =>
            {
                foreach (var pass in numberArray)
                {
                    Console.Write(pass);
                }
            });
          
            timer.Stop();

            var timeTaken = timer.Elapsed.TotalSeconds;
            string foo = "Time taken Asynchronized bubble sort method: " + timeTaken.ToString();
            Console.WriteLine(foo);
        }

    }
}
