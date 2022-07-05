namespace stacksAndQueues
{
    public class Stack<T>
    {
        LinkedList<T> linkedList;
        public Stack()
        {
            this.linkedList = new LinkedList<T>();
        }
        public void Push(T data)
        {
            linkedList.AddFirst(data);
        }
        //LIFO last element will pop out
        public void Pop()
        {
            linkedList.RemoveFirst();
        }

        //peek method will show thefirst elemrnt in the Linklist, does not delete the node from the ll
        public void PeeK()
        {
            Console.WriteLine(linkedList.First());
        }
    }
}