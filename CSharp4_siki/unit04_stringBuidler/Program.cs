using System.Text;
//stringBuilder字符串本身会发生变化。与string不同，string自身不会变化。
StringBuilder sb = new StringBuilder("道长是个大好人！");
sb.Append("对对对！");
sb.Insert(7, "~");
sb.Replace("好", "恶");

Console.WriteLine(sb.ToString());
StringBuilder sb2 = new StringBuilder(10);//可以设置初始容量；