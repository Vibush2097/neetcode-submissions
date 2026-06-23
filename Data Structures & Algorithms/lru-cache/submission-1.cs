public class Node
{
    public int key;
    public int val;
    public Node next;
    public Node prev;

    public Node(int key, int val)
    {
        this.key = key;
        this.val = val;
        next = null;
        prev = null;
    }
}

public class LRUCache {
    Node left;
    Node right;
    Dictionary<int, Node> cache;
    int capacity;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        cache = new Dictionary<int, Node>();
        left = new Node(-1, -1);
        right = new Node(-1, -1);
        left.next = right;
        right.prev = left;
    }
    
    public int Get(int key) {
        if (!cache.ContainsKey(key))
            return -1;

        var node = cache[key];
        RemoveNode(node);
        InsertNode(node);
        return node.val;
    }
    
    public void Put(int key, int value) {
        if (cache.ContainsKey(key)) {
            RemoveNode(cache[key]);
        }
        var node = new Node(key, value);
        cache[key] = node;
        InsertNode(node);

        if (cache.Count > capacity) {
            Node lru = left.next;
            RemoveNode(lru);
            cache.Remove(lru.key);
        }
    }

    private void RemoveNode(Node node) {
        Node prev = node.prev;
        Node nxt = node.next;
        prev.next = nxt;
        nxt.prev = prev;
    }

    private void InsertNode(Node node) {
        Node prv = right.prev;
        prv.next = node;
        right.prev = node;
        node.prev = prv;
        node.next = right;
    }
}
