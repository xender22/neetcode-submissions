public class Node
{
    public int Value { get; set; }
    public Node? Next { get; set; }
    public Node? Prev { get; set; }

    public Node(int value)
    {
        Value = value;
    }
}

class Deque 
{
    public Node? Head { get; set; }
    public Node? Tail { get; set; }
   
    public Deque() 
    {
        
    }

    public bool isEmpty() 
    {
        return Head == null;
    }

    public void append(int value) 
    {
        var newNode = new Node(value);
        if (Tail == null)
        {
            Head = newNode;
            Tail = newNode;
            return;
        }

        Tail.Next = newNode;
        newNode.Prev = Tail;
        Tail = newNode;

    }

    public void appendleft(int value) 
    {
        var newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
            return;
        }

        newNode.Next = Head;
        Head.Prev = newNode;
        Head = newNode;
    }

    public int pop() 
    {
        if (Tail == null)
            return -1;

        var result = Tail.Value;
        Tail = Tail.Prev;
        if (Tail == null)
            Head = null;
        else
            Tail.Next = null;
        return result;
    }

    public int popleft() 
    {
        if (Head == null)
            return -1;
        
        var result = Head.Value;
        Head = Head.Next;
        if (Head == null)
            Tail = null;
        else
            Head.Prev = null;
        return result;
    }
}