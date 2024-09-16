public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int wp = n + m - 1;
        m -= 1; n -= 1;
        while (wp >= 0)
        {
            if (m < 0)
            {
                nums1[wp] = nums2[n];
                wp--; n--;
            }
            else if (n < 0)
            {
                nums1[wp] = nums1[m];
                wp--; m--;
            }
            else if (nums1[m] > nums2[n])
            {
                nums1[wp] = nums1[m];
                wp--;
                m--;
            }
            else
            {
                nums1[wp] = nums2[n];
                wp--;
                n--;
            }
        }
    }
}
