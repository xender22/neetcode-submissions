public class DynamicArray {

    private int Capacity;
    private int[] Collection;
    private int Size = 0;
    
    
    public DynamicArray(int capacity) {
        Capacity = capacity;
        Collection = new int[Capacity];
    }

    public int Get(int i) {
        return Collection[i];
    }

    public void Set(int i, int n) {
        Collection[i] = n;
    }

    public void PushBack(int n) {
        if (Size >= Collection.Length)
            Resize();

        Collection[Size] = n; 
        Size++;   
    }

    public int PopBack() {
        Size--;
        var lastElement =  Collection[Size];
        Collection[Size] = 0;

        return lastElement;
    }

    private void Resize() {
        Capacity *= 2;
        int[] newCollection = new int[Capacity];

        for (int i = 0; i < Collection.Length; i++) 
        {
            newCollection[i] = Collection[i];
        }

        Collection = newCollection;
    }

    public int GetSize() {
        return Size;
    }

    public int GetCapacity() {
        return Capacity;
    }
}
