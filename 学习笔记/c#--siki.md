# c#--siki

## 一、循环的格式

### 1. if

> ```c#
> if（条件）
> {
>     
> }
> ```

### 2. switch

> ``` c#
> switch(变量)
>     case(0):{};
> 	case(1):{};
> ...
>     break;
> ```
>
> 

### 3. while

> ```c#
> while(满足条件)
> {}
> ```
>
> 

### 4. for

> ```c#
> for(定义，条件，跳出)
> {}
> ```
>
> 

### 5. do...while

> ```c#
> do
> {}
>     while(条件);
> ```
>
> 

## 二、常用方法

### 1.控制输入输出：

```c#
Console.ReadLine();//获取当前行
Console.WriteLine();//输出并换行
Console.Write();//输出
```

### 2. 转换字符类型

```c#
Convert.ToInt32();//Convert：转换类型
```

### 3. 获取单个字符

读取一个字符的输入

```c#
```

### 4.强制类型转换

​	（强制转换的类型）int a；

​	eg：int a=(int) float num;(将浮点形强制转换成int类型)

> Q：C#中Convert与强制转换之间的区别
>
> A：Convert与强转最大的区别是 增加了范围校验，如果不在范围内，直接抛出异常。
>
> [参考链接]https://blog.csdn.net/ylq1045/article/details/128114314
>
> > C#中小数转化为整数，Convert转换原理如下：如果小数部分小于0.5，或者小数部分大于0.5，则按照四舍五入的方式获取整数
> >
> > C#中小数转化为整数，Convert转换原理如下：如果小数部分等于0.5，则返回最接近的偶数，即返回的偶数与原小数的差的绝对值相差0.
> >
> > > by源泽：console.writeline不好使的时候可以试试debug.writeline

## 三、数据基本类型

​	整型：按照存储值的范围不同，c#语言将整形分成了byte类型

short类型、int类型、long类型等，并分别定义了有符号数和无符号数。

​	有符号数可表示负数；无符号数只能表示正数。

​	https://www.runoob.com/csharp/csharp-data-types.html

![image-20230209212902006](C:\Users\mkdz\AppData\Roaming\Typora\typora-user-images\image-20230209212902006.png)

​	动态（Dynamic）类型：

​		Dynamic：可以存极大值（底层转成字符串存储）

​	显示转换：大范围数据类型值塞入小范围数据类型时，使用（数据类型）

​	隐示类型转换：小范围类型转入大范围类型[编译器无法判断数据是否丢失]

​	编译器只检查容器大小，不检查容器内的具体数值大小。因为数值作为变量是随时变化的。

强制类型转换的对象需要类型一致。

eg：int a=（int）“3342”；字符串无法转为数字。

### 1.字符串

### 2.数组

- 表达形式：

  ​	定义一个数组：int[] a;

  ​	给数组赋值：

  ​	int[] a ={1,2,4,1,2,3,1};

  ​	int[] a=new int[4];//长度为4的空数组

  ​	int[] a= new int [4]{1,2,4,2};

  ​	int[] a;

  ​	a=new int [3]{1,2,3};

