using System;
using System.Collections.Generic;
using System.Text;

namespace unit020Mylist列表
{
    class MyList<T>
    {
        private T[] data = new T[0];//自定义类型的数组,长度默认为0
        public int Capacity
        {
            get { return data.Length; }
                
            
        }
        private int count=0;
        public void Add(T item)//item代表列表里的数据
        {
            if (data.Length == 0)
            {
                data = new T[4];
            }
            if (data.Length == count)
            {
                T[] temp = new T[2 * count];
                for (int i = 0; i < data.Length; i++)
                {
                    temp[i] = data[i];
                }
                data = temp;
            }
            data[count] = item;
            count++;
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
  
        //索引器
        public T this[int index]
        {
            get 
            {
                if (index < 0 || index > count - 1)
                {
                    throw new ArgumentOutOfRangeException("超出索引范围");
                }
                return data[index];
            }
            set
            {
                data[index] = value; 
            }
        }
        //添加数据
        //public void Insert(int index, T item)
        //{
        //    if (index < 0 || index > count - 1)
        //    {
        //        throw new ArgumentOutOfRangeException("超出索引范围");
        //    }
        //    //从后往前遍历
        //    for (int i = count - 1; i > index - 1; i--)
        //    {
        //        data[i + 1] = data[i];

        //    }
        //    data[index] = item;
        //    count++;
        //}
        ///insert
        public void Insert(int index, T item)
        {
            if (index < 0 || index > count - 1)
            {
                throw new ArgumentOutOfRangeException("索引参数超出范围了");
            }

            for (int i = count - 1; i > index - 1; i--)
            {
                // count-1     index
                data[i + 1] = data[i];
            }
            data[index] = item;
            count++;
        }
        //delate
        public void RemoveAt(int index)
        {
            if (index < 0 || index > count - 1)
            {
                throw new ArgumentOutOfRangeException("索引参数超出范围了");
            }
            for (int i = index + 1; i < count; i++)
            {
                // index+1   count-1
                data[i - 1] = data[i];
            }
            count--;
        }
        public int IndexOf(T item)
        {
            int index = -1;
            for (int i = 0; i < count; i++)
            {
                //
                if (item.Equals(data [i]))
                {
                    index = i;break;
                }
            }
            return index;
        }
        public int LastIndexOf(T item)
        {
            int index = -1;

            for (int i = count - 1; i >= 0; i--)
            {// ToString Equals
                if (item.Equals(data[i]))
                {
                    index = i; break;
                }
            }
            return index;
        }
        //
        public void Sort()
        {
            Array.Sort(data, 0, count);
            //可对某个数组进行排序。
        }
    }
}
