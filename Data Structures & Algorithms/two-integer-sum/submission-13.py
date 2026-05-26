class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:

        if len(nums) == 2:
            return [0, 1]

        num_dict = {value: index for index, value in enumerate(nums)}
        first_index = None
        second_index = None
        diff = None

        for i in range(len(nums)):
            diff = target - nums[i]
            if diff in num_dict and num_dict[diff] != i:
                first_index = i
                break
        
        for i in range(len(nums) -1, 0, -1):
            print(i)
            print(diff, nums[i])
            if diff == nums[i]:
                second_index = i
                break
        
        return [first_index, second_index]


        
        


        