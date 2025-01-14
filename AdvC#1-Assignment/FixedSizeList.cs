using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_1
{
    internal class FixedSizeList<T>
    {

        int count;
        int capacity;
        List<T> list;

        public FixedSizeList(int capacity)
        {
            this.count = 0;
            this.capacity = capacity;
            this.list = new List<T>(capacity);
        }


        public void Add(T item)
        {
            if (count >= capacity)
            {
                Console.WriteLine(" The List Is Full Capacity ");
                return;
            }

            list.Add(item);
            count++;
        }


        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine(" Invalid index, It's Out Of the range of This list ");
                return default(T);
            }

            return list[index];
        }


        public int Capacity => capacity;

        public int Count => list.Count;

    }
}
