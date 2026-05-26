class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False

        s = list(s)
        t = list(t)

        while len(s) > 0:
            if s[0] in t:
                index = t.index(s[0])
                del t[index]
                del s[0]
            else:
                return False


        return True
        