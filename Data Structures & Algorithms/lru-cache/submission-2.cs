public class Node {
    public int key;
    public int val;
    public Node next;
    public Node prev;

    public Node(int k, int v) {
        key = k;
        val = v;
        next = null;
        prev = null;
    }
}

public class LRUCache {
    int cap;
    int cur;
    Node head;
    Node tail;
    Dictionary<int, Node> nodes;

    public LRUCache(int capacity) {
        cap = capacity;
        cur = 0;
        head = new Node(-1,-1);
        tail = new Node(-1,-1);
        head.next = tail;
        tail.prev = head;
        nodes = new Dictionary<int, Node>();
    }
    
    public int Get(int key) {
        if (nodes.ContainsKey(key)) {
            Node node = nodes[key];
            RemoveNode(key);
            AddNode(node);
            return node.val;
        }

        return -1;
    }
    
    public void Put(int key, int value) {
        if (nodes.ContainsKey(key)) {
            RemoveNode(key);
            nodes[key].val = value;
            AddNode(nodes[key]);
            return;
        }

        Node newNode = new Node(key, value);
        if (cur < cap) {
            cur++;
        }
        else {
            int lruKey = tail.prev.key;
            RemoveNode(lruKey);
            nodes.Remove(lruKey);
        }
        AddNode(newNode);
        nodes[key] = newNode;
    }

    private void AddNode(Node newNode) {
        Node temp = head.next;
        head.next = newNode;
        newNode.prev = head;
        newNode.next = temp;
        temp.prev = newNode;
    }

    private void RemoveNode(int key) {
        Node node = nodes[key];
        Node tempPrev = node.prev;
        Node tempNext = node.next;
        tempPrev.next = tempNext;
        tempNext.prev = tempPrev;
    }
}