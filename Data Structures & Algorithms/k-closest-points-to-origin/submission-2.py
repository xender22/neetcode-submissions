import math

class Solution:
    def corToVal(self, cor: List[int]) -> float:
        x, y = cor
        return math.sqrt(x ** 2 + y ** 2)

    def kClosest(self, points: List[List[int]], k: int) -> List[List[int]]:
        
        max_idx = len(points) - 1
        self.qSort(points, 0, max_idx)
        return points[:k]
    
    def qSort(self, arr: List[List[int]], s: int, e: int) -> List[List[int]]:
        if s >= e:
            return arr

        pivot = self.corToVal(arr[e])
        left = s    
        for i in range(s, e):
            dist = self.corToVal(arr[i])
            if dist < pivot:
                tmp = arr[left]
                arr[left] = arr[i]
                arr[i] = tmp
                left += 1
        
        tmp = arr[left]
        arr[left] = arr[e]
        arr[e] = tmp
    
        # Quick sort left side
        self.qSort(arr, s, left - 1)

        # Quick sort right side
        self.qSort(arr, left + 1, e)

        return arr
