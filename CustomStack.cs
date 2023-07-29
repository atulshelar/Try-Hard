using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryHard.Stack_Queues
{
    public class CustomStack
    {
        protected int[] data;
        private const int DEFAULT_SIZE = 10;
        int ptr = -1;
        public CustomStack() : this(DEFAULT_SIZE)
        {
        }

        public CustomStack(int size)
        {
            this.data = new int[size];
        }

        public virtual bool Push(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full!!");
                return false;
            }
            ptr++;
            data[ptr] = item;
            return true;
        }

        public int Pop() {
            if (IsEmpty())
            {
                throw new StackException("Cannot pop element inside the stack");
            }
            return data[ptr--];
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new StackException("Cannot peek from an empty stack!!");
            }
            return data[ptr];
        }

        private bool IsEmpty()
        {
            return ptr == -1;
        }

        public  bool IsFull()
        {
            return ptr == data.Length - 1;
        }
    }

    public class StackException : Exception
    {
        public StackException(string message) : base(message)
        {
        }
    }
}
