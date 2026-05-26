class Solution:
    def isValid(self, s: str) -> bool:
        char_stack = []
        char_map = {
            "}": "{",
            "]": "[",
            ")": "("
        }

        if s[0] in char_map:
            return False
    
        for c in s:
            if c not in char_map:
                char_stack.append(c)
            else:
                top = char_stack.pop() if char_stack else None
                if char_map[c] != top:
                    return False
        
        return len(char_stack) == 0
                

        
        