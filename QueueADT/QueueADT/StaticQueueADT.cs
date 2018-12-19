using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueADT
{
    public class StaticQueueADT
    {
        private const int CAPACITY = 1000;
        //Attributes
        private int[] entries;
        private int head;
        private int tail;
        private int count;

        //Constructors
        public StaticQueueADT()
        {
            entries = new int[CAPACITY];
            head = 0;
            tail = 0;
            count = 0;
        }

        //Checking if the queue is full
        public bool IsFull { get { return tail == CAPACITY; } }

        //Checking if the queue is empty
        public bool IsEmpty { get { return tail == 0; } }

        //Get the size of the queue
        public int Size { get { return count; } }

        //Display all elements in queue
        public void Print()
        {
            for (int counter = head; counter < tail; counter++)
            {
                Console.Write(entries[counter] + " | ");
            }
        }

        //Adding an element to the queue
        public void Enqueue(int element)
        {
            if (IsFull) { throw new System.InvalidOperationException("Error: Static Queue is full"); }
            
            entries[tail] = element;
            tail++;
            count++;
            
        }

        //Removing the first element in the queue
        public int DeQueue()
        {
            if (IsEmpty) { throw new System.InvalidOperationException("Error: Static Queue is empty"); }
            int element = entries[head];
            head++;
            count--;
            return element;
        }

        //Checking the first element in the queue
        public int Peek()
        {
            return entries[head];
        }
    }
}
