public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0, next = nums.Length - 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                while (next > 0)
                {
                    if (nums[next] != val)
                    {
                        nums[i] = nums[next];
                        next--;
                        break;
                    }
                    next--;
                }
            }
            else
                k++;
        }
        return k;
    }
}
