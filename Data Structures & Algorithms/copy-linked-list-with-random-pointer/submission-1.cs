/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head == null) {
            return head;
        }

        List<Node> nodes = new List<Node>();
        Dictionary<Node, Node> dict = new Dictionary<Node, Node>();
        Node cur = head;

        while (cur != null) {
            Node newNode = new Node(cur.val);
            dict[cur] = newNode;
            cur = cur.next;
        }

        cur = head;
        while (cur != null) {
            Node node = dict[cur];
            node.next = cur.next != null ? dict[cur.next] : null;
            node.random = cur.random != null ? dict[cur.random] : null;
            cur = cur.next;
        }

        return dict[head];
    }
}
