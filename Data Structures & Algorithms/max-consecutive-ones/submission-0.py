class Solution:
    def findMaxConsecutiveOnes(self, nums: List[int]) -> int:
        curr_result = 0
        max_result = 0

        for num in nums:
            if num == 1:
                curr_result += 1
            else:
                curr_result = 0
            
            if curr_result > max_result:
                    max_result = curr_result
            

        return max_result