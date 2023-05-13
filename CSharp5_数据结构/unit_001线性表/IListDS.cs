using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_001线性表
{
    interface IListDS<T>
    {
        int GetLength();//获取长度
        void Clear();//清空
        bool IsEmpty();//是否为空
        void Add(T item);//添加
        void Insert(T item, int index);//插入
        T Delete(int index);//删除
        T this[int index] { get; }//查找获取值
        T GetEle(int index);//
        int Locate(T value);//查找位置
    }
}
