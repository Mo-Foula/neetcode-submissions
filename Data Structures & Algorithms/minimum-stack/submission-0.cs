public class MinStack {
    List<int> L;

    public MinStack() {
        L = new List<int>() ;
    }
    
    public void Push(int val) {
        L.Add(val) ;
    }
    
    public void Pop() {
        L.RemoveAt(L.Count -1);
    }
    
    public int Top() {
        return L[L.Count -1];
    }
    
    public int GetMin() {
        var x = L[0];
        foreach(var i in L){
            x = Math.Min(x, i);
        }
return x;
    }
}
