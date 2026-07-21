class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        last_idx = len(nums) - 1
        suf = [1, nums[0]]
        pre = [1, nums[last_idx]]
        result = []

        sum = nums[0]
        for i in range(1, last_idx):
            print(i)
            sum *= nums[i]
            suf.append(sum)
        
        sum = nums[last_idx]
        for i in range(last_idx - 1, 0, -1):
            print(nums[i])
            sum *= nums[i]
            pre.append(sum)

        pre.reverse()


        for i in range(len(nums)):
            result.append(pre[i] * suf[i])
            

        print(f"prefix: {pre}, suffix: {suf}")
        

        
        return result