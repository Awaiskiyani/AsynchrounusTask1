using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchrounusTask1
{
    internal class AsyncSortArrayWithQuickSort
    {
        public static async Task QuickSortAsync(int[] arr, int left, int right)
        {
            await Task.Run(async () =>
            {
                if (left < right)
                {
                    int pivot =await PartitionAsync(arr, left, right);

                    if (pivot > 1)
                    {
                      await  QuickSortAsync(arr, left, pivot - 1);
                    }
                    if (pivot + 1 < right)
                    {
                      await  QuickSortAsync(arr, pivot + 1, right);
                    }
                }
            });
         
        }

        public static async Task<int> PartitionAsync(int[] arr, int left, int right)
        {

            int pivot = arr[left];
          

            while (true)
            {

                
                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }


                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;
                    await Task.Run(() =>
                    {
                        int temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;
                    });
                  
                }
                else
                {
                    // Return the right pointer indicating the partitioning position
                    return right;
                }
            }
        }
    }
}
