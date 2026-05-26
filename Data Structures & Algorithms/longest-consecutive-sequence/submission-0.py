class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        highest_count = 0
        num_hash = set(nums)

        for n in nums:
            if n - 1 not in num_hash and n in num_hash:
                count = 0
                while n in num_hash:
                    count += 1
                    n += 1

                if count > highest_count:
                    highest_count = count
        return highest_count
            
                


        