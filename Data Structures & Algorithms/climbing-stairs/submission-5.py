class Solution:
    def climbStairs(self, n: int) -> int:

        if n <= 1:
            return n
        
        base_fib = [1,1]
        i = 2

        while i <= n:
            tmp = base_fib[1]
            base_fib[1] =  base_fib[0] + base_fib[1]
            base_fib[0] = tmp
            i += 1
        return base_fib[1]