class Solution:
    def merge(self, nums1: List[int], m: int, nums2: List[int], n: int) -> None:
        """
        Do not return anything, modify nums1 in-place instead.
        """
        if m <= 0:
            nums1[:] = nums2
        
        max = len(nums1) - 1
        for i in range(len(nums1)):
            if n <= 0 or (nums1[m - 1] > nums2[n - 1] and m > 0):
                nums1[max - i] = nums1[m - 1]
                m -= 1
            else:
                nums1[max - i] = nums2[n - 1]
                n -= 1

        