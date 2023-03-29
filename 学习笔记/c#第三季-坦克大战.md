# c#-siki

[TOC]

### 一、多线程

#### 线程的休眠

【线程】

- 定义：
  线程-程序的执行路径，每个线程执行特定的工作。是轻量级进程节省了CPU周期的浪费

- main--相当于在主线程中运行。

  所有的程序都在线程中运行

  ```c#
   Thread t = Thread.CurrentThread;//获取到当前的线程
   t.Name = "mainThread";
  
  ```

  

【多线程】

线程之间同时进行，不分先后

开启一个新的线程的方法：

- 先有一个方法

- ```c#
   private static void ChildThreadMethod(){
              Console.WriteLine("子线程进行中！");
              while (true)
              {
                  Console.WriteLine("我是子线程");
              }
          }    class Program
      {
          static void Main(string[] args)
          {
         
              ThreadStart start = new ThreadStart(ChildThreadMethod);
    
              Thread ChildThead = new Thread(start);
  //下一句等价于上方的两句。
              //先声明一个线程，添加线程开始时调用的方法。
              Thread test = new Thread(new ThreadStart(ChildThreadMethod));
              ChildThead.Start();
              test.Start();
              Console.WriteLine("MainThead");
              while (true)
              {
                  Console.WriteLine("babababa");
                  Thread.Sleep(1);//1s=1000ms
              }
  
          }
          private static void ChildThreadMethod()
          {
              Console.WriteLine("子线程进行中！");
              while (true)
              {
                  Console.WriteLine("我是子线程");
              }
          }
  
      }
  ```

  - Thread.Sleep（）；
    线程休眠（）内以毫秒为单位；1s=1000ms

- 终断任务--强制终断

  - 线程.Abort();

- 终断线程--添加一个标志位

  - 使用bool值来控制

### 二、类型转换

自动类型转换-适用情况：右侧取值范围小于左侧

#### 基类与派生类的转换

```c#
class Program{
        static void Main(string[] args)
        {
            Father f = new Son();//将son强制类型转换为Father；又称用战斗机做客机

            Son s = (Son)f;//将Father类强制转换为son类 此时s获得了son类的功能
            Son s = f as Son;//另一种写法
            s.SonMethod();
        }
    }
    class Father
    {        
    }
    class Son : Father
    {
        public void SonMethod()
        { }
    }
```

四、

![image-20230228214510099](C:\Users\mkdz\AppData\Roaming\Typora\typora-user-images\image-20230228214510099.png)

![image-20230228214828650](C:\Users\mkdz\AppData\Roaming\Typora\typora-user-images\image-20230228214828650.png)

### 五、

 this.StartPosition = FormStartPosition.CenterScreen;//设置窗体显示的位置。显示在焦点屏幕上
            //this.StartPosition = FormStartPosition.Manual;//设置窗体显示的位置。
           // this.Location = new Point(123, 1080);

```c#
         this.StartPosition = FormStartPosition.CenterScreen;//设置窗体显示的位置。显示在焦点屏幕上
            //this.StartPosition = FormStartPosition.Manual;//设置窗体显示的位置。
           // this.Location = new Point(123, 1080);
        //GDI=> Graphics Device Interface图形设备接口//常用技术
        //屏幕坐标系y轴坐标轴朝下，以左上角为原点。
```

#### 清晰化代码

#region
#endregion
用来控制可收缩的区域，并可以显示标识文字。

### 坦克大战开发

#### 1）新增一个线程

​	为什么线程调用的是静态方法：因为普通函数需要构造方法所在的类的对象（通过类来调用）

