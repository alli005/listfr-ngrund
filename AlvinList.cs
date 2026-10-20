using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace listfr_ngrund
{
    
    public class AlvinList
    {
        private int[] data = new int[10];
        private int count = 0;
        public int Count => count;
        public int this[int index]
        {
            get => data[index];
            set
            {
                data[index] = value;
            }
        }

        public void Add(int item)
        {
            if(count == data.Length)
            {
                Grow();
            }
            data[count] = item;
            count++;
        }
        private void Grow()
        {
            int[] tmp = new int[data.Length * 2];
            for(int i = 0; i < count; i++)
            {
                tmp[i] = data[i];
            }
            data = tmp;
        }
        public void Remove(int item)
        {
            for(int i = 0; i< count; i++)
            {
                if(item == data[i])
                {
                    RemoveAt(i);
                    return;
                }
            }
        }
        public void RemoveAt(int index)
        {
            if(index >= data.Length) return;
            for(int j = index; j < count; j++)
            {
                data[j] = data[j+1];
            }
            count--;
        }
        public void Insert(int item, int index)
        {
            if(index > count || index < 0) return;
            if(count == data.Length)
            {
                Grow();
            }
            for(int i = count; i > index; i--)
            {
                data[i] = data[i-1];
            }
            data[index] = item;
            count++;
        }
    }
}