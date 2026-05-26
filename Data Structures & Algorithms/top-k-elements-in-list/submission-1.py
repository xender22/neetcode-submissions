class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        frequency_dict = defaultdict(int)

        for num in nums:
            frequency_dict[num] += 1
        
        frequency_list = sorted(frequency_dict.items(), key=lambda item: item[1], reverse=True)
        print(frequency_list)

        
        return [item[0] for item in frequency_list[:k]]

