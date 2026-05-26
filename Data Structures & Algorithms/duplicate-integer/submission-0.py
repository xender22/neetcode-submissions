class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        dupe_set = set()
        for num in nums:
            dupe_set.add(num)

        if len(nums) != len(dupe_set):
            return True
        return False
        