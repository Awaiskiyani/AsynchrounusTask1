using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchrounusTask1
{
    internal class SortArrayWithBubbleSort
    {

        
        public static int[] GenerateArray()
        {
            int[] array = new int[30];
            Random randomNumbers = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNumbers.Next(0, 100) + i;

            }
            return array;
        }
        public static int[] SortArray()
        {

            var array = GenerateArray();
            Console.WriteLine("without Sorting");

                                                                        

            foreach (var item in array)
            {
                Console.Write(item+",");
            }



            Console.WriteLine("started sort array");   


            //  Sorting with Bubble Sort
            var arrayLenght = array.Length;

            for (int i = 0; i < arrayLenght - 1; i++)
            {

                for (int j = 0; j < arrayLenght - 1 ; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var tempNumer = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tempNumer;
                    }
                  
                }
            }
         
            return array;
        }


        


        //sort array with bubble sort with time Execution
     public  static void StopwatchBubbleSortSynchronize()
        {
            //A: Setup and stuff you don't want timed
            var timer = new Stopwatch();
            timer.Start();
            var numberArray = SortArray();
            foreach (var pass in numberArray)
            {
                Console.Write(pass+",");
            }
            timer.Stop();

            var timeTaken = timer.Elapsed.TotalSeconds;
            string foo = "Time taken synchonized bubble sort method: " + timeTaken.ToString();
            Console.WriteLine(foo); 
        }

       

        //sort arry with Buubble sort Asynchronously
        public static async Task< Array> SortArrayAsync()
        {

            int[] array = new int[50];
            Random randomNumbers = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                //Task.Delay(1000).Wait();
                array[i] = randomNumbers.Next(0, 100) + i;                   //Generating random Array
            }



            Console.WriteLine("without Sorting");



            foreach (var item in array)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("started sort array");


            //  Sorting with Bubble Sort
            var arrayLenght = array.Length;

            for (int i = 0; i < arrayLenght - 1; i++)
            {

                for (int j = 0; j < arrayLenght - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var tempNumer = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tempNumer;
                    }

                }
            }



            return array;
        }

        //public static async Task StopwatchBubbleSortASynchronize()
        //{
        //    //A: Setup and stuff you don't want timed
        //    var timer = new Stopwatch();
        //    timer.Start();

        //    var numberArray =await AsyncMethods.SortedAsyncArray();


        //    foreach (var pass in numberArray)
        //    {
        //        Console.WriteLine(pass);
        //    }
        //    timer.Stop();

        //    var timeTaken = timer.Elapsed.TotalSeconds;
        //    string foo = "Time taken Asynchronized bubble sort method: " + timeTaken.ToString();
        //    Console.WriteLine(foo);
        //}


    }

}
