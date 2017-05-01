using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DefiningClassesPart2
{
    class GenericList<T> where T:IComparable
    {
        private int defaultSize = 4;
        private int index=0;
        private T[] list;

        public GenericList()
        {
            this.list = new T[defaultSize];
        }
        public GenericList(int defaultSize)
        {
            this.list = new T[defaultSize];
            this.defaultSize = defaultSize;
        }

        public T this[int index]
    {
        get { return this.list[index]; }
        set
        {
            if (index < 0 || index > list.Length)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
            else
                this.list[index] = value;
        }

    }

        public void Add(T element)
        {
            if(this.index > this.list.Length)
            {
                ResizeArray();
            }

            this.list[index] = element;

            index++;
        }

        public void RemoveAt(int index)
        {
            if(index<0 || index>list.Length)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }

            for(int i=index;i<list.Length-1;i++)
            {
                this.list[i] = list[i + 1];
            }
            list[list.Length - 1] = default(T);
            index--;
        }
        public void InsertAtIndex(T element,int index)
        {
            if (index < 0 || index > list.Length)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
            if(this.index>this.list.Length)
            {
                ResizeArray();
            }
            for(int i=this.list.Length-1;i>index;i--)
            {
                list[i] = list[i - 1];
            }   
            list[index] = element;
            this.index++;

        }

        private void ResizeArray()
        {
            var newList = new T[this.list.Length * 2];
            for(int i=0;i<list.Length;i++)
            {
                newList[i] = this.list[i];
            }
            this.list = newList;


        }

        public void Clear()
        {
            list = new T[defaultSize];
        }
        
        public T Get(int index)
        {
            if(index < 0 || index > list.Length)
            {
               throw new IndexOutOfRangeException();
            }
            return this.list[index];
        }
        public int IndexOf(T value)
        {

            for (int i = 0; i < list.Length;i++ )
            {
                if (list[i].ToString() == value.ToString())
                {
                    return i;
                }
            }
            return -1;
        }


        public T Min()
        {
            T min = list[0];
            for(int i=0;i<list.Length;i++)
            {
                if(min.CompareTo(list[i]) > 0)
                {
                    min = list[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = list[0];
            for (int i = 0; i < list.Length; i++)
            {
                if (max.CompareTo(list[i]) < 0)
                {
                    max = list[i];
                }
            }
            return max;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("[");
            for(int i=0;i<list.Length;i++)
            {
                if (i != list.Length - 1)
                {
                    builder.Append(list[i] + ",");
                }
                else
                    builder.Append(list[i]);
            }

            builder.Append("]");
            return builder.ToString();
        }

        
    }
}
