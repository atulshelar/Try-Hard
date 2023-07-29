using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TryHard.Stack_Queues
{
    public class CircularQueue
    {
        protected int[] data;
        private const int DEFAULT_SIZE = 10;

        protected int end = 0;
        protected int front = 0;
        private int size = 0;

        public CircularQueue() : this(DEFAULT_SIZE)
        {
        }

        public CircularQueue(int size)
        {
            this.data = new int[size];
        }

        public bool IsFull()
        {
            return size == data.Length; // ptr is at the last index
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public virtual bool Insert(int item)
        {
            if (IsFull())
            {
                return false;
            }
            data[end++] = item;
            end = end % data.Length;
            size++;
            return true;
        }

        public int Remove()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty");
            }

            int removed = data[front++];
            front = front % data.Length;
            size--;
            return removed;
        }

        public int Front()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty");
            }
            return data[front];
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty");
                return;
            }
            int i = front;
            do
            {
                Console.Write(data[i] + " -> ");
                i++;
                i %= data.Length;
            } while (i != end);
            Console.WriteLine("END");
        }
    }
    
}
