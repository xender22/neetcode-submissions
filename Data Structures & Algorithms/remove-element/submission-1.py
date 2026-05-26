class Solution:
    def removeElement(self, nums: List[int], val: int) -> int:
        skip = 0
        
        for i in range(len(nums)):
            if nums[i] == val:
                skip += 1
                nums[i] = -1
                continue
            nums[i - skip] = nums[i]
    
        result = len(nums) - skip
        return result