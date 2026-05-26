class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:

        if len(nums) == 2:
            return [0, 1]

        num_dict = {value: index for index, value in enumerate(nums)}
        
        for i in range(len(nums)):
            diff = target - nums[i]
            if diff in num_dict and num_dict[diff] != i:
                return [i, num_dict[diff]]
        
        


        
        


        