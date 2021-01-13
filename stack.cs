using System.Collections.Generic;

namespace Problems
{
  static class myStack
  {
    static Queue<int> q = new Queue<int>();
    public static void Push(int x) {
        q.Enqueue(x);
        for( int i =0; i < q.Count -1; i++)
        {
            q.Enqueue(q.Dequeue());
        }
    }
    public static int Pop() {
        return q.Dequeue();
    }
    public static int Top() {
        return q.Peek();
    }
    public static bool Empty() {
        return q.Count == 0;
    }
  }
}