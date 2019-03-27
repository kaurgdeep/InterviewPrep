//a.Remove duplicate nodes from an unsorted singly-linked listFor example:
//Given: e -> b -> e -> a -> c -> e -> f -> a 
//  Return: e -> b -> a -> c -> f


namespace RemoveDupdInUnsortedList
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