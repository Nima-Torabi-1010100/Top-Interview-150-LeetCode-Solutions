public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
            int iw = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i-1] != nums[i])
                {
                    nums[iw] = nums[i];
                    iw++;
                }
            }
            return iw;
    }
}
