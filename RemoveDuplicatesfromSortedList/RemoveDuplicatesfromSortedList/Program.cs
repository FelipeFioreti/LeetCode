using RemoveDuplicatesfromSortedList;

ListNode head = new ListNode(1);
head.next = new ListNode(1);
head.next.next = new ListNode(2);
head.next.next.next = new ListNode(3);
head.next.next.next.next = new ListNode(3);

Console.WriteLine(DeleteDuplicates(head));

ListNode DeleteDuplicates(ListNode head)
{
    if (head == null)
    {
        return head;
    }

    ListNode current = head;

    while (current != null && current.next != null)
    {
        if (current.val == current.next.val)
        {
            current.next = current.next.next;
        }
        else
        {
            current = current.next;
        }
    }

    return head;
}
