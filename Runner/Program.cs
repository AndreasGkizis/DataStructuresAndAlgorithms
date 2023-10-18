using DataStructures.BinaryTree;
using DataStructures.Deque;
using DataStructures.DoublyLinkedList;
using DataStructures.HashTables;
using DataStructures.SinglyLinkedLists;
using DataStructures.SortedList;

namespace Runner
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        #region singly linked lists


            //var node1 = new SinglyLinkedListNode<string>("node 1");
            //var node2 = new SinglyLinkedListNode<string>("node 2");
            //var node3 = new SinglyLinkedListNode<string>("node 3");
            //var node4 = new SinglyLinkedListNode<string>("node 4");

            //node1.Next = node2;
            //node2.Next = node3;
            //node3.Next = node4;

            //var test = new PureSinglyLinkedList<string>();
            //var testExtra = new ExtraSinglyLinkedList<string>();
            //var testEmpty = new PureSinglyLinkedList<string>();

            //testExtra.AddHead("node #1");
            //testExtra.AddHead("node #1");
            //testExtra.AddHead("node #1");
            //test.AddHead("node #1");
            //test.AddHead("node #2");
            //test.AddHead("node #3");
            //test.AddHead("node #4");
            //test.AddHead("node #5");
            //test.AddHead("node #6");
            //test.AddHead("node #7");

            //test.AddTail("node #0");
            //test.AddTail("node #-1");
            //test.AddTail("node #-2");

            //Console.WriteLine(test.ToString());
            //Console.WriteLine(test.Contains("node #7"));

            //Console.WriteLine(test.Contains("qweqwe"));
            //System.Console.WriteLine(test.Remove("node #7"));
            //Console.WriteLine(test.ToString());
            //System.Console.WriteLine(test.Remove("node #5"));

            //foreach (var item in test)
            //{
            //    System.Console.WriteLine(item);
            //}

            #endregion

            #region doubly linked lists
            //var node1 = new DoublyLinkedListNode<string>("node 1");
            //var node2 = new DoublyLinkedListNode<string>("node 2");
            //var node3 = new DoublyLinkedListNode<string>("node 3");
            //var node4 = new DoublyLinkedListNode<string>("node 4");

            //var test = new PureDoublyLinkedList<string>();

            //test.AddTail("node #0");
            //test.AddHead(node4);
            //test.AddHead(node3);
            //test.AddHead(node2);
            //test.AddHead(node1);
            //test.AddHead("node #5");
            //test.AddHead("node #6");
            //test.AddHead("node #7");


            //test.AddTail("node #-1");
            //test.AddTail("node #-2");
            //test.RemoveHead();
            //test.RemoveTail();

            //test.RemoveNode("node 4");
            //test.ToString();

            #endregion

            #region SortedLists

            // var node1 = new DoublyLinkedListNode<int>(1);
            // var node2 = new DoublyLinkedListNode<int>(2);
            // var node3 = new DoublyLinkedListNode<int>(3);
            // var node4 = new DoublyLinkedListNode<int>(4);
            // var node5 = new DoublyLinkedListNode<int>(5);

            // var test = new SortedList<int>();

            // test.Add(node1);
            // test.Add(node5);
            // test.Add(node3);


            // test.ToString();
            #endregion

            #region Deque

            // var node1 = new DoublyLinkedListNode<int>(1);
            // var node2 = new DoublyLinkedListNode<int>(2);
            // var node3 = new DoublyLinkedListNode<int>(3);
            // var node4 = new DoublyLinkedListNode<int>(4);
            // var node5 = new DoublyLinkedListNode<int>(5);

            // var test = new Deque<int>();

            // test.EnqueueHead(node1);
            // test.EnqueueHead(5);
            // test.EnqueueHead(5);
            // test.EnqueueHead(5);
            // test.EnqueueHead(5);
            // test.EnqueueHead(5);
            // test.EnqueueHead(5);
            // test.EnqueueHead(5);
            // var result = test.PeekHead();
            // System.Console.WriteLine(test.DequeueTail());
            // System.Console.WriteLine(test.DequeueTail());

            // foreach (var item in test)
            // {
            //     System.Console.WriteLine(item);
            // }

            #endregion

            #region Binary Trees

            // BinaryTreeNode<string> nodeG = new("G");
            // BinaryTreeNode<string> nodeD = new("D");
            // BinaryTreeNode<string> nodeH = new("H");
            // BinaryTreeNode<string> nodeB = new("B");
            // BinaryTreeNode<string> nodeC = new("C");
            // BinaryTreeNode<string> nodeZ = new("Z");
            // BinaryTreeNode<string> nodeY = new("Y");
            // BinaryTreeNode<string> nodeK = new("K");
            // BinaryTreeNode<string> nodeJ = new("J");
            // BinaryTreeNode<string> nodeX = new("X");

            // var testtree = new BinaryTree<string>();
            // testtree.Add(nodeG);
            // testtree.Add(nodeD);
            // testtree.Add(nodeH);
            // testtree.Add(nodeB);
            // testtree.Add(nodeC);
            // testtree.Add(nodeZ);
            // testtree.Add(nodeY);
            // testtree.Add(nodeK);
            // testtree.Add(nodeJ);
            // testtree.Add(nodeX);

            // System.Console.WriteLine("Inside the () is a bigger int  | ==> result : {0}", 1.CompareTo(2));
            // System.Console.WriteLine("Inside the () is the same int  | ==> result : {0}", 1.CompareTo(1));
            // System.Console.WriteLine("Inside the () is a smaller int | ==> result : {0}", 2.CompareTo(1));
            #endregion

            #region HashTables

            var myhash = new HashTable<string, int>();
            // collisions can happen since it is a limited and bad indexing code
            myhash.Add("Avocado", 1);
            myhash.Add("Banana", 2);
            myhash.Add("Orange", 34);
            myhash.Add("Strawberry", 123);
            myhash.Add("Cherry", 56);

            
            Console.WriteLine(myhash.ContainsKey("Banana"));
            Console.WriteLine(myhash.ContainsKey("orange"));
            Console.WriteLine(myhash.ContainsKey("Orange"));
            Console.WriteLine(myhash.ContainsKey("lathos"));

            #endregion
        }
    }
}
