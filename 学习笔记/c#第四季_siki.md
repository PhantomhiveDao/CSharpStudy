# siki c#第四季

1. 字符串好好学习，其他可以后期遇到再学。

1. 命名空间-namespace

   1. 目的：为了给类进行分类。

   2. 使用：命名空间之间可以嵌套

      ```c#
      namespace unit02namespace
      {
          namespace namespace2
          {
              internal class Class2
              {
      
              }
      
          }
         
      }
      ```

## 字符串和正则表达式

```
1. 字符串类
  	1. System.String
  	2. System.Text.StringBuilder
2. 字符串是静态的 不能被修改。
3. 字符串的方法
  	1. 
```

## 正则表达式-regular Expression/规则表达

1. 检索：通过正则表达式，从字符串中获取我们想要的部分

2. 匹配：判断给定字符串是否符合正则表达式的过滤逻辑。
   1. ）正则表达式表述了一个字符串的书写规则。
   
      > 类[Regex](https://learn.microsoft.com/zh-cn/dotnet/api/system.text.regularexpressions.regex?view=net-8.0)表示.NET Framework的正则表达式引擎。 它可用于快速分析大量文本以查找特定的字符模式;提取、编辑、替换或删除文本子字符串;和 ，将提取的字符串添加到集合以生成报表。
   
   ``` c#
    Regex.IsMatch(str1, "");
               Console.WriteLine(Regex.IsMatch(str1, @"\d*"));
               //@字符：令特殊字符失效；元字符
               //\n换行；\t制表符；\d任意一个数字;* 前边的包含零个或多个
               //\w大小写字母，0-9
               //\D;\W补集；反义字符。
               //[]中的任意字符的集合只要字符串中包含则为true ；可以用“-”添加连续的；；[^A-D]：A-D以外的字符
               Console.WriteLine(Regex.IsMatch(str1, @"si*"));//s si sii siiiii
               Console.WriteLine(Regex.IsMatch(str1, @"^4"));//^以^之后的字符开头；对开始位置进行匹配；$匹配结尾
               //判断是否为合法标识符。
               //替换符合规则的字符
               Console.WriteLine(Regex.Replace("88382asdf34235", @"[0-9]", "!"));
               //限制字符长度{n,m}闭区间
               //择一匹配，匹配左边或者右边 “|”
               Console.WriteLine(Regex.IsMatch("88382asdf34235", @"\d|a"));
               //重复的字符串{n}；重复分组（）
               Console.WriteLine(Regex.IsMatch("abab",@"(ab){2}"));//abab
               Console.WriteLine(Regex.IsMatch("abab",@"(abc){2}"));//abcabc
   ```
   
   

## 委托

先定义，再使用。

定义的语法：

``` c#
	delegate void IntMethodInvoker（int x）;
```

> [委托](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/builtin-types/reference-types)是一种引用类型，表示对具有特定参数列表和返回类型的方法的引用。
> 在实例化委托时，你可以将其实例与任何具有兼容签名和返回类型的方法相关联。 
> 你可以通过委托实例调用方法。
>
> **委托**用于将方法作为参数传递给其他方法。 事件处理程序就是通过委托调用的方法。 
> 你可以创建一个自定义方法，当发生特定事件时，某个类（如 Windows 控件）就可以调用你的方法。 

> 在方法重载的上下文中，方法的签名不包括返回值。 
> 但在委托的上下文中，签名包括返回值。 
> 换句话说，**方法**和**委托** *必须具有相同的返回类型*。

>委托具有以下属性：
>
>- 委托类似于 C++ 函数指针，但委托完全面向对象，不像 C++ 指针会记住函数，委托会同时封装对象实例和方法。
>- 委托允许将方法作为参数进行传递。
>- 委托可用于定义回调方法。
>- 委托可以链接在一起；例如，可以对一个事件调用多个方法。
>- 方法不必与委托类型完全匹配。 有关详细信息，请参阅[使用委托中的变体](https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/concepts/covariance-contravariance/using-variance-in-delegates)。
>- 使用 Lambda 表达式可以更简练地编写内联代码块。 Lambda 表达式（在某些上下文中）可编译为委托类型。 若要详细了解 lambda 表达式，请参阅 [lambda 表达式](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/lambda-expressions)。

//定义了一个委托指向了int

### Action

​	委托的一种类型，返回值为空。只能指向没有返回值的方法

### Function

​	委托的一种类型，需要在标签中声明返回值的类型，例：

``` c#
 Func<string> fc1 = TestFunction;
```



### 多播委托

​	只能得到调用的最后一个方法的结果。

>     委托也可以包含多个方法，这种委托就叫做多播委托。
>     可以按照顺序调用多个方法。
>     多播委托只能得到调用的最后一个方法的结果
>     一般我们把多播委托的返回类型声明为void
>     【多播委托】包含一个逐个调用的委托集合
>     如果通过委托调用的其中一个方法抛出异常，则整个迭代就会停止。

​	包含了一个委托的集合

​		如何获得这个集合：

```c#
Delegate[] dels=ac1.GetInvocationList();//返回的是Delegate类这个类型的数组
 foreach(Delegate de in dels) 
            {
                de.DynamicInvoke();//DynamicInvoke：动态调用
            }
```

### 匿名方法

​	用的地方很少。

​	减少代码复杂性。

```c#
//Func<int,int,int>puls=delegate(int a,int b){ return a + b; };

            //lambda表达式：一种语法规则；可以对复杂一些的匿名方法进行简化
            Func<int, int, int> puls = (a, b) => { return a + b; };
            //当lambda表达式中只有一条语句时，可以进一步简化
            Func<int, int, int> test = (x, y) => x - y;
            //Func<传递参数类型，传递参数类型，返回参数类型>匿名方法名称=（参数1，参数2）=>
            int res = puls(3 ,4);
            Console.WriteLine(res);
            //lambda可以访问外部变量;但是容易结果不可控，容易出现编程问题
            int a = 90;
            Func<int, int, int> F = (x, y) => x - y+a;
```

### 事件event

>  	加了event之后委托有了限制：该委托只能+=或者-=；并且只能在内部进行调用。
>     编译成 创建一个私有的委托示例，和施加在其上的add、remove方法
>     添加了event之后，只允许用add remove方法来操作，导致不匀速在类的外部被直接触发，只能在类的内部适合的世纪触发。
>     委托可以在外部被触发。但不建议这么使用
>     委托常用来表达回调（回调函数）；事件表达外发【消息订阅的一个机制】的接口。

## LINQ

### 用法

​	在数据（集合）中做查询
​		可以为后期学习数据库做准备（服务器端开发）

​	客户端开发用不到linq

​	了解，可以跳过。

## 反射和特性-用的不多

```
#### 什么是元数据和反射
```

​		BCL-（basic Class Lib）基础类库

​	有关程序及其类型的数据被称为元数据（metadata）保存在程序的程序集中。

​	文件后缀：dll；.exe

​	Type
​		通过type可以获得到类里面指定的一些信息。
​		比如：成员，方法，字段，命名空间...

```c#
using System;
using System.Reflection;

namespace unit13_反射
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type
            Type type = typeof(MyClass1);
            Console.WriteLine(type.Name);
            Console.WriteLine(type.Namespace);
            Console.WriteLine(type.Assembly);
            FieldInfo[] fis= type.GetFields();
            foreach (FieldInfo fi in fis) 
            { 
            Console.WriteLine(fi.Name);
            }
            PropertyInfo[] pis=type.GetProperties();
            foreach (PropertyInfo pi in pis)
            {
                Console.WriteLine(pi.Name);
            }
            MethodInfo[] methodInfos = type.GetMethods();
            foreach (MethodInfo mi in methodInfos)
            {
                Console.WriteLine(mi.Name);
            }

        }
    }
}

```

#### 如何加载程序集

## 特性

1. Obsolete(过时的):对方法增加描述可以标记为弃用，作为提示。

2. Conditional(条件)：在引用命名空间之前【#define】一个宏，用来控制方法是否启用。

   ```c#
   #define ISshowMessage//定义一个宏
   //宏
   using System;
   using System.Diagnostics;
   namespace unit14_特性
   {internal class Program
       {[Obsolete("请用新的nwetest",false)]//特性：obsolete标记为弃用;
           static void Test( ) 
           { Console.WriteLine("Hello World!"); }     
           static void newTest( )
           {        }
           [Conditional("ISshowMessage")]
           static void ShowMessage(string str )
           {Console.WriteLine(str);        }
           static void Main(string[] args)
           {   Test();
               ShowMessage("qwq");
               Console.WriteLine("---------");
               ShowMessage("TaT");        }
       }
   }
   
   ```

   

### 定义

​	是一种允许我们向程序的程序集增加元数据的语言结构。用于保存程序结构信息的某种特殊类型的类。
​	（相当于文档的批注）

> ​	将应用了特性的程序结构叫目标。
> ​	设计用来获取和使用元数据的程序（对象浏览器）叫做特性的消费者。
> ​	.NET预定了很多特性，我们也可以生命自定义特性。

#### 自定义特性

## 线程、任务、同步

### 线程



#### 概念

> 一个进程的多个线程可以同时运行在不同的CPU上或多核CPU的不同内核上。

一个应用程序启动，会启动一个进程（应用程序运行的载体），然后进程启动多个线程。
进程包含资源，如Window句柄、文件系统句柄嚯其他内核对象。
每个进程都分配的虚拟内存。一个进程至少包含一个线程。

> 程序 ->进程->线程

程序（我们写的代码-静态观念）

### 创建

​	使用Thread类可以创建和控制线程

> Thread构造函数的参数是一个无参、无返回值的**委托类型**

### 任务

类型：一个类

在命名空间：System.Threading.Tasks，包含了类抽象出了线程功能，在后台使用ThreadPool进行管理。

任务表示应完成某个单元的工作。这个工作可以在单独的线程中运行，也可以以同步方式启动一个任务。

任务也是异步编程中的一种实现方式。

#### 启动任务

- 启动任务的三种方式

- ``` c#
  using System;
  using System.Threading;
  using System.Threading.Tasks;
  
  namespace unit26
  {
      class Program
      {
          //多线程の任务
          static void Main(string[] args)
          {
              //构造工厂实例
              ///TaskFactory tf = new TaskFactory();
              ///Task t=tf.StartNew(Test);//为什么没有执行：因为是后台线程，主线程结束之后会同步停止。
              //Task：用来执行一些小任务
              //可以通过task对象获得一些相关的信息
              ///Thread.Sleep(5000);
              ///通过构造Task对象
              Task t = new Task(Test);
              t.Start();
              Thread.Sleep(5000);
  
          }
          static void Test()
          {
              for (int a = 0; a < 1000; a++)
              {
                  Console.WriteLine("test方法");
  
              }
          }
      }
  }
  ```

- 

#### 连续任务

定义：如果一个任务t1的执行是依赖于另一个任务t2的，那么就需要在这个任务t2执行完毕后才开始执行t1。这个时候我们可以使用连续任务。

人话版：有了t2才能有t1时，需要先执行完t2再执行t1。可以使用连续任务解决。

``` 
using System;
using System.Threading;
using System.Threading.Tasks;

namespace unit26
{
    class Program
    {
        //多线程の任务
        static void Main(string[] args)
        {
            //构造工厂实例
            ///TaskFactory tf = new TaskFactory();
            ///Task t=tf.StartNew(Test);//为什么没有执行：因为是后台线程，主线程结束之后会同步停止。
            //Task：用来执行一些小任务
            //可以通过task对象获得一些相关的信息
            ///Thread.Sleep(5000);
            ///通过构造Task对象
            //Task t = new Task(Test);
            //t.Start();
            //Thread.Sleep(5000);
            Task t1 = new Task(Mask1);
            Task t2=t1.ContinueWith(Mask2);
            //使用连续任务时，需要在被连续的任务中添加Task变量。为了获得上一个函数传出的值。
            t1.Start();
            Thread.Sleep(5000);
        }
        static void Test()
        {
            for (int a = 0; a < 1000; a++)
            {
                Console.WriteLine("test方法");

            }
        }
        static void Mask1()
        {
            for (int i=0; i < 10; i++)
            {
                Console.WriteLine("11111");
            }
            Thread.Sleep(2000);
        }
        static void Mask2(Task t)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("22222");
            }
            Thread.Sleep(2000);

        }
    }
}

```



### 同步

在一个线程中执行

### 异步

新开一个线程

#### 前台线程 后台线程

##### 前台线程：

> 只要有一个前台线程在运行，应用程序的进程就在运行。
>
> 如果，多个前台线程在运行，但是main方法结束了。进程仍然运行，直到所有前台线程完成任务为止
>
> **可以推测出：前台线程优先级高于后台线程**
>
> 后台线程：以服务用的为主

默认情况下Thread类创建的线程是前台线程。线程池中的线程总是后台线程。

Thread类中有个属性IsBackGround

### 线程的优先级

### cpu处理线程的方式

> 以毫秒为单位，切换线程交替进行。
>
> - 调度规则：随机调用一个线程（？）优先级高的，被随机到的概率大

#### 线程优先级的级别：

```c#
设置Priority属性；是ThreadPriority枚举定义的一个值。
    定义的级别有：Highest；AboveNormal，Normal,BelowNormal,Lowset
    //具体表现为
Thread a = new Thread(A);
a.Priority= ThreadPriority.BelowNormal;

    
```

#### 控制线程

1. 获取线程的状态——Running/Unstarted
   1. 调用Start方法之后，不是马上进入Running状态，二十储物Unstarted状态。只有当操作系统的线程调度器选择了要运行的线程，线程的状态才会修改为Running状态
   2. 使用Thread.Sleep()方法让当前线程休眠，进入WaitSleepJoin状态
   3. 

### 线程池

> 创建线程需要时间。如果有不同的小任务需要返程，可以事先创建多个线程。

#### ThreadPool类

> 会在需要时增减池中的线程数直到达到最大线程数
>
> 最大线程数可以配置。
>
> 双核CPU中，默认设置为1023个工作线程和1000个I/o线程。
>
> ​		也可以指定在创建线程池时应该立即启动的最小线程数，以及线程池中可用的最大线程数。
> ​		如果有更多的作业要处理，线程池中现成的个数也到了极限，最新的作业就要排队，且必须等待线程完成其他任务。
>
> **不能把入池的线程改为前台线程**
> **不能给入池的线程设置优先级或名称**

####  资源访问冲突

##### 产生原因：
	同一个方法中的参数，在多线程中被调用。

- 例：方法中，变量a会自增后输出延迟1秒后归0。在线程A执行时a加1，在线程B执行时a加1；此时可能产生使出2的可能。

##### 解决方案：

  - 使用lock（一种语法）

    - 缺点：当资源多且不同资源使用的情况不同时，当前线程，会降低其他需要调用资源的线程的效率

> **死锁**
>
> 产生情景：
>
> 当线程们因为调用了不同的发放都要使用资源A和资源B时，为防止资源访问冲突使用了lock后。
> 发现，由于调用的lock的变量先后顺序不一致，导致需要的资源无法按需取出导致程序无法进行下去。
>
> ``` c#
>  public void ChangeState1()
>  {lock (_lock1)  {               Console.WriteLine(Thread.CurrentThread.ManagedThreadId+"state1中的lock111");
>                 lock (_lock2)
>                 {
>                 }
> public void ChangeState2()
>         {
>             lock (_lock2)
>             { Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "state2中的lock222");
> 
>                 lock (_lock1)
>                 {}
> ```
>
> **解决方法**
>
> 将使用锁的先后顺序在方法中进行统一。

## 文件操作

### 对文件进行读写

#### FileInfo和DirectoryInfo类

文件信息、文件夹信息

- FileInfo:对文件进行读写修改

- DirectoryInfo

  > 下面的类用于浏览文件系统和执行操作，比如移动，复制和删除文件。 
  >
  > System.MarshalByRefObject 这个是.NET类中用于远程操作的基对象类，它允许在应 用程序域之间编组数据。 FileSystemInfo 这是表示任何文件系统对象的基类
  >
  >  FileInfo和File 这些类表示文件系统上的文件
  >
  >  DirectoryInfo和Directory 表示文件系统上的文件夹 Path 包含用于处理路径名的一些静态方法
  >
  >  DriveInfo 它的属性和方法提供了指定驱动器的信息

##### 表示文件和文件夹的.NET类 

我们有两个用于表示文件夹的类和两个用于表示文件的类 Directory（文件夹）和File（文件）类只包含静态方法，不能被实例化。
如果只对文件夹 或文件执行一个操作，使用这些类就很有效，省去了去实例化.NET类的系统开销。
 DirectoryInfo类和FileInfo类实现与Directory和File相同的公共方法，他们**拥有一些公共 属性和构造函数**，这些类的成员都不是静态的。
<u>需要实例化这些类</u>，之后把每个实例与特定 的文件夹或者文件关联起来。
如果使用同一个对象执行多个操作，使用这些类比较合适，这是因为在构造的时候他们将读取合适文件系统对象的身份验证和其他信息，无论每个对象调 用了多少方法，都不需要再次读取这些信息。

#### Path类-工具类

- 不能去实例化Path类
- Path类提供了一些静态方法，可以更容易的对路径名执行操作。

### 对文件内容进行读写

#### File类可以读写文件本身。

> 1,File.ReadAllText(FilePath);根据文件路径读取文件中所有的文本 2,File.ReadAllText(FilePath,Encoding);//Encoding可以指定一个编码格式 Encoding.ASCII; 3,File.ReadAllBytes()方法可以打开二进制文件把内容读入一个字节数组 4,File.ReadAllLines() 以行的形式读取文件，一行一个字符串，返回一个字符串的数组 写入文件 我们读取文件有ReadAllText() ReadAllLines()和ReadAllBytes()这几个方法，对应的写入 文件的方法有WriteAllText() WriteAllLines()和WriteAllBytes()

#### 流

##### 定义

数据的一种处理方式

##### 用途

数据小，则可以一次性搬运；数据大，则可以把数据当作谁，接一个水管，一点一点搬运。

###### 流媒体

流是一个用于传输数据的对象，数据可以向两个方向传输：
如果数据从外部源传输到程序中，这就是读取流；
如果数据从程序传输到外部源中，这就是写入流

外部源可能是：
一个文件、网络上的数据、内存区域上、读写到命名管道上

>读写内存使用System.IO.MemorySystem 处理网络数据使用System.Net.Sockets.NetworkStream

读取与写入结束的方法规则：先读取后写入，先关写入后关读取

读取流----写入流
输入流     输出流

##### 读写文本文件

###### StreamReader和StreamWriter
