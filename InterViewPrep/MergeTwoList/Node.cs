namespace MergeTwoList
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
        //private Node head { get; set; }

        //public void Append(Node node)
        //{
        //    if(head == null)
        //    {
        //        head = new Node(node.data);
        //        return;
        //    }
        //    var current = head;
        //    while(current != null)
        //    {
        //        if(current.next == null)
        //        {
        //            current.next = new Node(node.data);
        //            return;

        //        }
        //        current = current.next;
        //    }
        //}
    }
}