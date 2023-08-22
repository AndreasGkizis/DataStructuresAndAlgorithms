using LinkedLists;

namespace Runner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var node1 = new SinglyLinkedListNode<string>("node 1");
            var node2 = new SinglyLinkedListNode<string>("node 2");
            var node3 = new SinglyLinkedListNode<string>("node 3");
            var node4 = new SinglyLinkedListNode<string>("node 4");

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;

            var test = new SinglyLinkedList<string>();

            test.AddHead("node #1");
            test.AddHead("node #2");
            test.AddHead("node #3");
            test.AddHead("node #4");
            test.AddHead("node #5");
            test.AddHead("node #6");
            test.AddHead("node #7");

            test.AddTail("node #0");
            test.AddTail("node #-1");
            test.AddTail("node #-2");

            Console.WriteLine(  
            test.ToString()
                
                );

            //Console.WriteLine("end");
        }
    }
}