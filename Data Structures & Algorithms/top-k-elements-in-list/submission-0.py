class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        frequency_dict = defaultdict(int)

        for num in nums:
            frequency_dict[num] += 1
        
        frequency_dict = dict(sorted(frequency_dict.items(), key=lambda item: item[1], reverse=True))
        print(frequency_dict)

        
        return list(frequency_dict.keys())[:k]

