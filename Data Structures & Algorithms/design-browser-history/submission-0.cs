public class ListNode 
{
    public string Value {get;set;}
    public ListNode Next {get;set;}
    public ListNode Prev {get;set;}

    public ListNode(string value="", ListNode next=null, 
        ListNode prev=null) 
    {
        Value = value;
        Next = next;
        Prev = prev;
    }
    
}

public class BrowserHistory 
{
    public ListNode Head {get;set;}

    public BrowserHistory(string homepage) 
    {
        var initHead = new ListNode(homepage);
        Head = initHead;
    }
    
    public void Visit(string url) 
    {
        var currHead = new ListNode(url, null, Head);
        Head.Next = currHead;
        Head = currHead;
    }
    
    public string Back(int steps) 
    {
        for (var i = 0; i < steps; i++) 
        {
            if (Head.Prev == null)
                return Head.Value;
            
            Head = Head.Prev;
        }

        return Head.Value;
    }
    
    public string Forward(int steps) 
    {
        for (var i = 0; i < steps; i++) 
        {
            if (Head.Next == null)
                return Head.Value;
            
            Head = Head.Next;
        }

        return Head.Value;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */