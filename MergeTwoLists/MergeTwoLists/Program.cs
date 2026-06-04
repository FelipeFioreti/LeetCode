using MergeTwoLists;
using System.Collections;

ListNode list1 = new ListNode(1);
list1.next = new ListNode(2);
list1.next.next = new ListNode(3);

ListNode list2 = new ListNode(1);
list2.next = new ListNode(3);
list2.next.next = new ListNode(4);

Console.WriteLine(MergeTwoLists(list1, list2));

ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    
}
