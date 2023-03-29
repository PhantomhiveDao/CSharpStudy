using System;
using System.Collections.Generic;
using System.Text;

namespace unit015_练习题13
{
	public class B : A
	{

		public B()
		{

			Console.WriteLine('B');
		}
		public new void Fun()
		{

			Console.WriteLine("B.Fun()");
		}
	}
}
