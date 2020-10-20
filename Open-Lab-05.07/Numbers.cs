using System;

namespace Open_Lab_05._07
{
    public class Numbers
    {
        public int[] RemoveSmallest(int[] nums)
        {
            int[] ret = new int[nums.Length - 1];
            int s = 0;
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < nums[s])
                {
                    s = i;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == s)
                {

                }
                else
                {
                    ret[k] = nums[i];
                    k++;
                }
            }
            return ret;
        }
    }
}
