using System;
using System.Collections.Generic;
using System.Text;

namespace unit015_练习题13
{
	public abstract class A
	{
		public A()
		{
			Console.WriteLine('A');
		}
		public virtual void Fun()
		{
			Console.WriteLine("A.Fun()");
		}
	}
}
