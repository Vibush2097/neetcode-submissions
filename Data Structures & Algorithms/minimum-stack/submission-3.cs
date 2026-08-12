public class MinStack {
    Stack<int> values;
    Stack<int> minValue;

    public MinStack() {
        values = new Stack<int>();
        minValue = new Stack<int>();
    }
    
    public void Push(int val) {
        values.Push(val);

        if (minValue.Count > 0) {
            minValue.Push(Math.Min(minValue.Peek(), val));
        }
        else {
            minValue.Push(val);
        }
    }
    
    public void Pop() {
        values.Pop();
        minValue.Pop();
    }
    
    public int Top() {
        return values.Peek();
    }
    
    public int GetMin() {
        return minValue.Peek();
    }
}
