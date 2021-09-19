using System;

namespace Remove_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };


            RemoveElement(arr, 2);
            Console.WriteLine("Hello World!");
        }

        static int RemoveElement(int[] nums, int val)
        {
            int len = nums.Length;
            int L = 0;
            for (int i = 0; i < len; i++)
            {
                if (nums[i] != val)
                {
                    if(i !=L)
                        nums[L] = nums[i ];
                    L++;
                }
                else if (i + 1 < len && nums[i + 1] != val)
                    nums[L] = nums[i + 1];
            }
            return L;
        }
    }
}
