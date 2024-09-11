public class Solution {
    public int MajorityElement(int[] nums) {
            int selected = nums[0];
            int n = nums.Length;
            int count = 1;
            for (int i = 1; i < n; i++)
            {
                if (selected == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                    if (count == 0)
                    {
                        selected = nums[i];
                        count = 1;
                    }
                }
            }
            count = 0;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == selected)
                    count++;
            }
            return selected;
    }
}
