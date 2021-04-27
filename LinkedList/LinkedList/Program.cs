using System;
using static LinkedList.LinkedList;

namespace LinkedList
{
    class Program
    {
        //try using insertion sort 
        //public static void sort(LinkedList linked)
        //{
        //    for(int i= 1; i<linked)
        //}
        static void Main(string[] args)
        {
            LinkedList lst = new LinkedList();
            lst.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);
            Node fourth = new Node(4);
            Node zero = new Node(0);
            lst.tail = new Node(5);


            
            lst.head.next = fourth;
            second.next = lst.tail;
            fourth.next = second;
            lst.addToBack(0);

            lst.addIndex(9,2);



            lst.printList();
        }
    }
}
