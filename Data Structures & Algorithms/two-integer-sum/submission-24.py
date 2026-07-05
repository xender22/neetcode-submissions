class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        if len(nums) == 2:
            return [0, 1]

        i = 0
        j = 0
        nums_map = {}

        for i in range (len(nums)):
            s_num = target - nums[i]
            
            if s_num in nums_map:
                j = nums_map[s_num]
                break
                
            nums_map[nums[i]] = i
        
        
        return [j, i]
       
        