using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedList
    {
        //the first node(head) of the linked list
        //will be an object of type Node (null be default)
      // public Node head;
        public class Node
        {
            public int data;
            public Node next = null;
          public Node(int data)
            {
                this.data = data;
            }
        }
        public Node head = null;
        public Node tail = null;


        public void printList()
        {
            Node n = head;
            while(n!= null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
        }

        public void addToFront(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            if(newNode.next == null)
            {
                tail = newNode;
            }
        }

        public void addToBack(int data)
        {
            Node newNode = new Node(data);
            if (tail == null)
            {
                head = newNode;
            }
            else
            {
                tail.next = newNode;
            }
            
            tail = newNode;
        }

        public void addIndex(int data, int idx)
        {
            Node newNode = new Node(data);
            Node current = head;
            for(int i = 0; i< idx-1; i++)
            {
                current = current.next;

            }
            newNode.next = current.next;
            current.next = newNode;
        
        }
    }
}
