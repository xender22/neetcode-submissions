class Solution:
    def strMapCount(self, s, s_set):
        for c in s:
            if c not in s_set:
                s_set[c] = 1
            else:
                s_set[c] += 1
    
    def mapCompare(self, s_set, t_set):
        for s in s_set:
            if s not in t_set or s_set[s] != t_set[s]:
                return False
        return True

    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False
        
        s_set = {}
        t_set = {}

        self.strMapCount(s, s_set)
        self.strMapCount(t, t_set)

        return self.mapCompare(s_set, t_set)