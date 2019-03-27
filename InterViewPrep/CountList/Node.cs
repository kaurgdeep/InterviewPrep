namespace CountList
{
    internal class Node
    {
        public int val { get; set; }
        public Node next { get; set; }

        public Node(int n)
        {
            val = n;
            next = null;
        }
    }
}