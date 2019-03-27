namespace InsertNodeAtPosition
{
    internal class Node
    {
        public Node(int val)
        {
            data = val;
            next = null;
        }
        public int data { get; set; }
        public Node next { get; set; }
    }
}