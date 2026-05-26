class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        result = []
        first_index = 0
        last_index = len(numbers) - 1

        i = 0
        while i < len(numbers):
            l = numbers[first_index]
            r = numbers[last_index]

            if l + r  > target:
                last_index -= 1
            elif l + r < target:
                first_index += 1
            else:
                first_index, last_index = first_index + 1, last_index + 1
                result.append(first_index)
                result.append(last_index)
                break

        return result
        



