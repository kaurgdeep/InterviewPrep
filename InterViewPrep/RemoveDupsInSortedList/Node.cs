namespace RemoveDupsInSortedList
{
    internal class Node
    {
        public char data { get; set; }
        public Node next { get; set; }
        public Node(char c)
        {
            data = c;
            next = null;
        }
    }
}