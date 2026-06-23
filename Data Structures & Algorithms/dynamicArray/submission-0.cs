public class DynamicArray {
    int[] array;
    int arrayCapacity, arraySize;
    
    public DynamicArray(int capacity) {
        array = new int[capacity];
        arrayCapacity = capacity;
    }

    public int Get(int i) {
        return array[i];
    }

    public void Set(int i, int n) {
        array[i] = n;
    }

    public void PushBack(int n) {
        if (arraySize == arrayCapacity) {
            Resize();
        }
        array[arraySize++] = n;
    }

    public int PopBack() {
        var back = array[arraySize-1];
        array[arraySize-1] = 0;
        arraySize--;
        return back;
    }

    private void Resize() {
        Array.Resize(ref array, 2 * arrayCapacity);
        arrayCapacity = 2 * arrayCapacity;
    }

    public int GetSize() {
        return arraySize;
    }

    public int GetCapacity() {
        return arrayCapacity;
    }
}
