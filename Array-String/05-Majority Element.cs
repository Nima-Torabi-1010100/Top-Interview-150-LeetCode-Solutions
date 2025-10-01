public class Solution {
    public int MajorityElement(int[] nums) {
            int condinate = nums[0];
            int count = 0;

            foreach (var num in nums)
            {
                if (count == 0)
                    condinate = num;
                count += condinate == num ? 1 : -1;
            }
            return condinate;
        }
    }
}
