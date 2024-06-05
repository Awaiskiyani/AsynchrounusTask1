using AsynchrounusTask1;

using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
internal class Program
{
    private static async Task Main(string[] args)
    {
      
         static int[] GenerateArray()
        {
            int[] array = new int[30];
            Random randomNumbers = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNumbers.Next(0, 100) + i;

            }
            return array;
        }

         var generatedArray= GenerateArray();                         

        

        SortArrayWithQuickSort.Quick_Sort(generatedArray,0,generatedArray.Length-1);
        Console.WriteLine("Sorting of Array with Quick Sort");
        foreach (int i in generatedArray)
        {
            Console.Write(i + ",");

        }
        Console.WriteLine();
        await AsyncSortArrayWithQuickSort.QuickSortAsync(generatedArray, 0, generatedArray.Length - 1);
        Console.WriteLine(" Async Sorting of Array with Quick Sort");
        foreach (int i in generatedArray)
        {
            Console.Write(i + ",");

        }
        Console.WriteLine() ;   
        Console.Write("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine();




        Console.WriteLine("Async and Sync sorting with Bubble sort");



        await AsyncSortArrayWithBubbleSort.StopwatchBubbleSortASynchronize();
        Console.WriteLine("**************************************");
        SortArrayWithBubbleSort.StopwatchBubbleSortSynchronize();
        Console.ReadKey();
    }
}