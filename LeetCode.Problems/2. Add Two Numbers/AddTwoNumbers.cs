namespace LeetCode.Problems._2._Add_Two_Numbers;

public class AddTwoNumber
{
    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {

        ListNode? result = null;
        ListNode? current = result;
        bool prevSumMoreThanTen = false;
        while (true)
        {
            if (l1 == null && l2 == null)
            {
                if (prevSumMoreThanTen)
                {
                    current!.next = new ListNode(1);
                }

                break;
            }

            int sum = 0;

            if (prevSumMoreThanTen)
            {
                sum += 1;
                prevSumMoreThanTen = false;
            }

            if (l1 != null)
            {
                sum += l1.val;
            }

            if (l2 != null)
            {
                sum += l2.val;
            }

            if (sum >= 10)
            {
                prevSumMoreThanTen = true;
            }

            if (current == null)
            {
                current = new ListNode(sum % 10);
                result = current;
            }
            else
            {
                current.next =  new ListNode(sum % 10);
                current = current.next;
            }

            l1 = l1?.next;
            l2 = l2?.next;
        }

        GC.Collect();
        return result!;
    }
    
    public static ListNode AddTwoNumbers2(ListNode l1, ListNode l2) {
        ListNode result = new ListNode();
        ListNode head = result;
        int carryOn = 0;
        while(l1 != null && l2 != null)
        {
            result.next = new ListNode();
            result = result.next;
            int sumoftwo = l1.val + l2.val + carryOn;
            result.val = sumoftwo % 10;
            carryOn = sumoftwo / 10;
            l1 = l1.next;
            l2 = l2.next;
        }
        if(l1 != null)
        {
            result.next = l1;
        }
        else if(l2 != null)
        {
            result.next = l2;
        }
            
        while(result.next != null && carryOn > 0)
        {
            result = result.next;
            int sum = result.val + carryOn;
            result.val = sum %10;
            carryOn = sum / 10;
        }
        if(carryOn > 0)
        {
            result.next = new ListNode();
            result.next.val = carryOn;
        }
        return head.next;
    }
}
