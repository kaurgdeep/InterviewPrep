namespace BuildList
{
    internal class Node
    {
        public int data { get; set;}
        public Node next { get; set; }
        public Node(int val)
        {
            data = val;
            next = null;
        }
    }
}