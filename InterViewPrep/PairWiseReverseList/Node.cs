//	9. Pair-wise reverse singly-linked list. 
//For example: Given a singly-linked list: a -> b -> c -> d -> e -> f 
// Return: b -> a -> d -> c -> f -> e


namespace PairWiseReverseList
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