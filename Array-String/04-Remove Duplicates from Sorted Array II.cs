public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int l = nums.Length;
        if (l <= 2) return l;
        int wp = 2;
        int i = 2;
        while (i < l)
        {
            if (nums[i] != nums[wp - 2])
            {
                nums[wp] = nums[i];
                wp++;
            }
            i++;
        }
        return wp;
    }
}
