class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:

        anagrams = {}

        for s in strs:
            letters = [0] * 26
            
            for c in s:
                letters[ord(c) - ord('a')] += 1

            string_numbers = [str(n) for n in letters]
            strKey = ":".join(string_numbers)
            if strKey not in anagrams:
                anagrams[strKey] = [s]
            else:
                anagrams[strKey].append(s)

        result = []
        for key in anagrams:
            result.append(anagrams[key])

        return result
            
            