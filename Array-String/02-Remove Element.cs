public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int l = nums.Length;
        int wp = 0;
        int i = 0;
        while (i < l)
        {
            if (nums[i] != val)
            {
                nums[wp] = nums[i];
                wp++;
            }
            i++;
        }
        return wp;
    }
}
