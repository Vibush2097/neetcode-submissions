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
        
        Dictionary<Node, Node> nodes = new Dictionary<Node, Node>();

        Node temp = head;
        while (temp != null) {
            if (!nodes.ContainsKey(temp)) {
                Node newNode = new Node(temp.val);
                nodes[temp] = newNode;
                temp = temp.next;
            }
        }

        temp = head;
        while (temp != null) {
            Node cur = nodes[temp];
            cur.next = temp.next != null ? nodes[temp.next] : null;
            cur.random = temp.random != null ? nodes[temp.random] : null;
            temp = temp.next;
        }

        return nodes[head];
    }
}
