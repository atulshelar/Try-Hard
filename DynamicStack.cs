using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryHard.Stack_Queues
{
    public class DynamicStack : CustomStack
    {
        public DynamicStack() : base()
        {
        }
        public DynamicStack(int size) : base(size)
        {
        }
        public override bool Push(int item)
        {
            // this takes care of it being full
            if (IsFull())
            {
                // double the array size
                int[] temp = new int[data.Length * 2];

                // copy all previous items to the new data
                for (int i = 0; i < data.Length; i++)
                {
                    temp[i] = data[i];
                }

                data = temp;
            }

            // at this point, we know that the array is not full
            // insert the item
            return base.Push(item);
        }
    }
}
