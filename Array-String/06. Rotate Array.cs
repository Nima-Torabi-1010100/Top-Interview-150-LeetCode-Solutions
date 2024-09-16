public class Solution {
    public void Rotate(int[] nums, int k) {
        int len = nums.Length;
        k %= len;
        Reverse(nums, 0, len - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, len - 1);
    }
    private void Reverse(int[] nums, int s, int e)
    {
        while (s < e)
        {
            int temp = nums[e];
            nums[e] = nums[s];
            nums[s] = temp;
            s++;
            e--;
        }
    }
}
