public class ListNode 
{
    public ListNode Next;
    public int Val;

    public ListNode(ListNode next=null, int val=0)
    {
        Next = next;
        Val = val;
    }
}

public class LinkedList 
{
    private ListNode Head;
    

    public LinkedList() 
    {
        Head = null;
    }

    public int Get(int index) 
    {
        var tmp = Head;
        for (var i = 0; i < index; i++)
        {
            if (tmp != null)
                tmp = tmp.Next;
            else
                return -1;
        }
        return tmp != null ? tmp.Val : -1;
    }

    public void InsertHead(int val) 
    {
        var newHead = new ListNode(Head, val);
        Head = newHead;
    }

    public void InsertTail(int val) 
    {
        if (Head == null) {
            InsertHead(val);
            return;
        }
        var tmpHead = Head;
        while (tmpHead.Next != null)
            tmpHead = tmpHead.Next;
        
        tmpHead.Next = new ListNode(null, val);
    }

    public bool Remove(int index) 
    {
        if (Head == null) return false;
        if (index == 0) {
            Head = Head.Next;
            return true;
        }

        var tmp = Head;
        for (var i = 0; i < index - 1; i++)
        {
            if (tmp.Next != null)
                tmp = tmp.Next;
            else
                return false;
        }

        if (tmp.Next == null) return false;
        tmp.Next = tmp.Next.Next;
        return true;
    }

    public List<int> GetValues() 
    {
        var result = new List<int>();
        var tmp = Head;
        while (tmp != null)
        {
            result.Add(tmp.Val);
            tmp = tmp.Next;
        }

        return result;
    }
}