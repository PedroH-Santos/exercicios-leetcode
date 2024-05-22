
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}


public class Solution116
{
    public Node Connect(Node root)
    {
        Node aux = root;

        if (aux == null) { return null; }

        if (aux.left != null && aux.right != null)
        {
            aux.left.next = aux.right;
        }

        if (aux.right != null)
        {
            if (aux.next != null)
            {
                if (aux.next.left != null)
                {
                    if (aux.next.left.left == null)
                    {
                        aux.right.next = aux.next.left;
                    }
                }
            }
        }

        aux.left = Connect(aux.left);
        aux.right = Connect(aux.right);
        return aux;
    }
}