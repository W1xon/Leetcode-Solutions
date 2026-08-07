using LeetCode.Common;

namespace LeetCode._100_199;

public class _142_LinkedListCycle
{
    public ListNode DetectCycle(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;
        bool hasCycle = false;
        while (fast is not null && fast.next is not null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast)
            {
                hasCycle = true;
                break;
            }
        }
        if (!hasCycle) return null;

        slow = head;
        while (slow != fast)
        {
            slow = slow.next;
            fast = fast.next;
        }
        return slow;
    }
}