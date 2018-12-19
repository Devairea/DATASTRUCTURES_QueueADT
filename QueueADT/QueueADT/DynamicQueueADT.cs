using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueADT
{
    public class DynamicQueueADT
    {
        private class Node
        {
            //Instance Variables
            internal int dataItem;
            internal Node nextNode;

            //Constuctor
            public Node(int v, Node n)
            {
                dataItem = v;
                nextNode = n;
            }

            //properties
            public int Value { get { return dataItem; } }
            public Node Next { get { return nextNode; } set { nextNode = value; } }
        }

        //Attributes of the Queue
        Node head;
        Node tail;
        int count;

        //Read-Only properties
        public int Size { get { return count; } }

        //Constructor
        public DynamicQueueADT()
        {
            head = null;
            tail = null;
            count = 0;
        }

        //Checking if Queue is full
        public bool IsFUll { get { return false; } }

        //Checking if Queue is empty
        public bool IsEmpty { get { return head == null; } }

        //Display all the elements in the Queue
        public void Print()
        {
            Node temp = head;
            while(temp != null)
            {
                Console.Write(temp.Value + " | ");
                temp = temp.Next;
            }

        }

        //Adding an element to the Queue
        public void Enqueue(int element)
        {
            Node temp = new Node(element, null);
            
            if(head == null)
            {
                head = tail = temp;
            }
            else
            {
                tail.Next = temp;
                tail = temp;
            }
            count++;
        }

        //Removing an element from the Queue
        public int Dequeue()
        {
            if (IsEmpty) { throw new InvalidOperationException("Error: Queue is empty"); }
            int element = head.Value;
            head = head.Next;
            count--;
            return element;
        }

        //Looking at the first value in the Queue
        public int Peek()
        {
            return head.Value;
        }







    }
}
