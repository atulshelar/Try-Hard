using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryHard.Stack_Queues
{
    public class CustomQueue
    {
        private int[] data;

        private const int DEFAULT_SIZE = 10;

        int end = 0;

        public CustomQueue() : this(DEFAULT_SIZE)
        {
        }

        public CustomQueue(int size)
        {
            this.data = new int[size];
        }

        public bool IsFull()
        {
            return end == data.Length; // ptr is at the last index
        }

        public bool IsEmpty()
        {
            return end == 0;
        }

        public bool Insert(int item)
        {
            if (IsFull())
            {
                return false;
            }
            data[end++] = item;
            return true;
        }

        public int Remove()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty");
            }

            int removed = data[0];

            // Shift the elements to the left
            for (int i = 1; i < end; i++)
            {
                data[i - 1] = data[i];
            }
            end--;
            return removed;
        }

        public int Front()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty");
            }
            return data[0];
        }

        public void Display()
        {
            for (int i = 0; i < end; i++)
            {
                Console.Write(data[i] + " <- ");
            }
            Console.WriteLine("END");
        }
    }
}
