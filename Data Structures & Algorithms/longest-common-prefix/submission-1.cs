public class TrieNode {
    public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
}

public class Trie {
    public TrieNode Root;

    public Trie() {
        Root = new TrieNode();
    }

    public void Insert(string word) {
        TrieNode node = Root;
        for (int i = 0; i < word.Length; i++) {
            char c = word[i];
            if (!node.Children.ContainsKey(c)) {
                node.Children[c] = new TrieNode();
            }
            node = node.Children[c];
        }
    }

    public int LongestCommonPrefix(string word, int prefixLen) {
        int n = Math.Min(word.Length, prefixLen);
        TrieNode node = Root;
        for (int i = 0; i < n; i++) {
            if (!node.Children.ContainsKey(word[i])) {
                return i;
            }
            node = node.Children[word[i]];
        }

        return n;
    }
}

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 1) {
            return strs[0];
        }

        int smallestWordIdx = 0;

        for (int i = 1; i < strs.Length; i++) {
            if (strs[i].Length < strs[smallestWordIdx].Length) {
                smallestWordIdx = i;
            }
        }

        Trie trie = new Trie();
        string smallestWord = strs[smallestWordIdx];
        trie.Insert(smallestWord);

        int prefixLength = smallestWord.Length;

        for (int i = 0; i < strs.Length; i++) {
            string word = strs[i];
            prefixLength = trie.LongestCommonPrefix(word, prefixLength);
        }

        return strs[0].Substring(0, prefixLength);
    }
}