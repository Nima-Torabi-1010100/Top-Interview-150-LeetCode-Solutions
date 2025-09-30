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
    public int RemoveDuplicates(int[] nums) 
    {
        int l = nums.Length;
        int wp = 0;
        int i = 0;
        while (i < l)
        {
            if (nums[i] != nums[wp])
            {
                wp++;
                nums[wp] = nums[i];
            }
            i++;
        }
        return wp + 1;
    }
}
