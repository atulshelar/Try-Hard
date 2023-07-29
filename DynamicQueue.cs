using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryHard.Stack_Queues
{
    public class DynamicQueue : CircularQueue
    {
        public DynamicQueue() : base()
        {
        }

        public DynamicQueue(int size) : base(size)
        {
        }

        public override bool Insert(int item)
        {
            // This takes care of it being full
            if (IsFull())
            {
                // Double the array size
                int[] temp = new int[data.Length * 2];

                // Copy all previous items to the new data
                for (int i = 0; i < data.Length; i++)
                {
                    temp[i] = data[(front + i) % data.Length];
                }
                front = 0;
                end = data.Length;
                data = temp;
            }

            // At this point, we know that the array is not full
            // Insert the item
            return base.Insert(item);
        }
    }
}
