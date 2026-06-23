public class MinStack {
    Stack<int> stack;
    Stack<int> minValue;

    public MinStack() {
        stack = new Stack<int>();
        minValue = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        
        if (minValue.Count() == 0) {
            minValue.Push(val);
        }
        else {
            minValue.Push(Math.Min(val, minValue.Peek()));
        }
    }
    
    public void Pop() {
        stack.Pop();
        minValue.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minValue.Peek();
    }
}
