public class Pair 
{
    public int Key;
    public int Value;

    public Pair (int key, int value)
    {
        Key = key;
        Value = value;
    }
}

public class HashTable 
{

    public Pair[] Table;
    public int Size;

    public HashTable(int capacity) 
    {
        Table = new Pair[capacity];
        Size = 0;
    }

    public void Insert(int key, int value) 
    {
        var idx = OpenIndex(Table, key % Table.Length, key); 
        if (Table[idx] == null)
            Size ++;
        Table[idx] = new Pair(key, value);

        if (Size * 2 >= Table.Length)
            Resize();
    }

    public int Get(int key) 
    {
        var idx = OpenIndex(Table, key % Table.Length, key);
        if (Table[idx] == null)
            return -1;
        return Table[idx].Value;
    }

    public bool Remove(int key) 
    {
        var idx = OpenIndex(Table, key % Table.Length, key); 
        if (Table[idx] == null)
            return false;

        Table[idx] = null;
        Size --;
        return true;
    }

    public int GetSize() 
    {
        return Size;
    }

    public int GetCapacity() 
    {
        return Table.Length;
    }

    public void Resize() 
    {
        var newCap = Table.Length * 2;
        var newTable = new Pair[newCap];

        // rehashing 
        foreach (var mem in Table)
        {
            if (mem == null) continue;
            var idx = OpenIndex(newTable, mem.Key % newCap, mem.Key);
            newTable[idx] = mem;
        }

        Table = newTable;
    }

    public int OpenIndex(Pair[] table, int idx, int key) 
    {
        while (table[idx] != null)
        {
            if (table[idx].Key == key)
                break;
            idx++;
        }
            
        if (idx == table.Length - 1)
            idx = 0;

        while (table[idx] != null)
        {
            if (table[idx].Key == key)
                break;
            idx++;
        }
        
        return idx;
    }
}
