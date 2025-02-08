// 1 -> 2 -> 4
// 1 -> 3 -> 4
// merged: 1 -> 1 -> 2 -> 3 -> 4 -> 4

var firstList = new ListNode(1);
var secondList = new ListNode(2);
var thirdList = new ListNode(4);
firstList.next = secondList;
secondList.next = thirdList;

var fourthList = new ListNode(1);
var fifthList = new ListNode(3);
var sixthList = new ListNode(4);
fourthList.next = fifthList;
fifthList.next = sixthList;
return;

ListNode MergeTwoLists(ListNode list1, ListNode list2) 
{
    // we need pointers for both lists
    
    // as we traverse the lists, we need to compare the val of one to the val of the other
    
    // greater than or equal to can be placed next to what we are comparing against
}

internal class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}