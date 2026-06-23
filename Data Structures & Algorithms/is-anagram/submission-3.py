from collections import Counter

class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        dict_s = dict(Counter(s))
        dict_t = dict(Counter(t))

        if len(dict_s) != len(dict_t):
            return False

        for key in dict_s:
            if not key in dict_t:
                return False
            
            if dict_t[key] != dict_s[key]:
                return False
        
        return True
