public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int iw = 0;
        if (nums.Length > 2)
        {
            iw = 2;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != nums[iw - 2] && iw <= i)
                {
                    nums[iw] = nums[i];
                    iw++;
                }
            }
            return iw;
        }
        return nums.Length;
    }
}
