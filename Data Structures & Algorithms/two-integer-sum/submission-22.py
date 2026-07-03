class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        if len(nums) == 2:
            return [0, 1]
        
        nums_set = set(nums)
        i = 0
        j = 0
        nums_map = {}

        for i in range (len(nums)):
            j_val = target - nums[i]
            nums_set.remove(nums[i])

            if j_val in nums_set:
                j = nums.index(j_val)
                break
            
            if j_val in nums_map:
                j = nums_map[nums[i]]
                break
            
            nums_set.add(nums[i])
            nums_map[nums[i]] = i

        if i < j:
            return [i, j]
        else:
            return [j, i]