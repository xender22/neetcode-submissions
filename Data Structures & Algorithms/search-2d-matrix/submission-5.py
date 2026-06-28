class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        min = 0
        max = len(matrix) - 1
        sub_arr = []

        while min <= max:
            mid = (min + max) // 2
            print(min, max, mid)
            if matrix[mid][0] < target:
                sub_arr = matrix[mid]
                min = mid + 1
            elif matrix[mid][0] > target:
                max = mid - 1
            else:
                return True
        
        min = 0
        max = len(sub_arr) - 1
        while min <= max:
            mid = (min + max) // 2

            if sub_arr[mid] < target:
                min = mid + 1
            elif sub_arr[mid] > target:
                max = mid - 1
            else:
                return True

        return False
        