
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
 
public class Solution2
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode head = new ListNode(0);
        ListNode sums = head;

        int rest = 0;
        int sum = 0;
        while (l1 != null || l2 != null)
        {
            int valL1 = (l1 != null) ? l1.val : 0;
            int valL2 = (l2 != null) ? l2.val : 0;

            sum = valL1 + valL2 + rest;
            rest = sum / 10;
            ListNode newSum = new ListNode(sum % 10);
            sums.next = newSum;
            sums = sums.next;

            if (l1 != null) { l1 = l1.next; }
            if (l2 != null) { l2 = l2.next; }
        }
        if (rest > 0)
        {
            ListNode newSum = new ListNode
            {
                val = rest
            };
            sums.next = newSum;
        }

        return head.next;

    }


}