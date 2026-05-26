class Solution:
    def getConcatenation(self, nums: List[int]) -> List[int]:
        result = []
        multiplier = 2

        while multiplier > 0:
            for i in range(len(nums)):
                result.append(nums[i])
            multiplier -= 1
        return result