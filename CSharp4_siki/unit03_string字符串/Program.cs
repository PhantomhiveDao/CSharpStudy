string s = "www.test.com.HHHHHH";
Console.WriteLine(s[4]);
Console.WriteLine(s=="88383");
s = "8848" + s;
//此处s指向了一个新的字符串。声明的字符串变量初始化后不会改变。
Console.WriteLine(s);
//比较
Console.WriteLine(s.CompareTo("8838"));
//替换
Console.WriteLine(s.Replace("h","?"));
//分割
Console.WriteLine(s.Split("."));
string[] test = s.Split(".");
foreach (string i in test)
{
    Console.WriteLine(i);
}
//截取字符串
Console.WriteLine(s.Substring(6,9));//从第六个字符开始截取9个字符

//大小写转换
Console.WriteLine(s.ToLower());
Console.WriteLine(s.ToUpper());

//去除前后空格
Console.WriteLine(s.Trim());


///静态方法-需要通过类名进行调用
//合并字符串
Console.WriteLine(string.Concat("123124"+"zdcvdsa"));
//copyto
char[] cA=new char[10];
s.CopyTo(7, cA, 5, 3);
foreach (char i in cA)
{
    Console.WriteLine(i);
}
Console.WriteLine();
//format格式化
float x = 23.82343f;
float y = 23;
float he = x+y;
Console.WriteLine(string.Format("{0}+{1}={2}",x,y,he));
//C使用货币形式输出；F2保留几位小数，自动四舍五入。；P1转百分比
Console.WriteLine(string.Format("{0:C}",x));
Console.WriteLine(string.Format("{0:F3}",x));
Console.WriteLine(string.Format("{0:P1}",x));

DateTime dateTime = DateTime.Now;
//HH-hour 24h制；hh12h制
Console.WriteLine(string.Format("{0:yyyy-MM-dd hh:mm:ss}",dateTime));
Console.WriteLine(dateTime.ToString("f"));
//IndexOf,字符串所在索引位置
Console.WriteLine(s.IndexOfAny("s,h".ToCharArray()));
//在某索引前插入字符串
Console.WriteLine(s.Insert(6, "????"));
//合并字符数组
char[] ca = { 'T','A','I','Q','I','A','N','G','L','a','!'};
Console.WriteLine(string.Join("", ca));
