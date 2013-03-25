using System;

namespace kinmokusei
{
	public class MySubClass1:MyDelegateAbstractClass
	{
		public MySubClass1 ()
		{
		}

		public override string Execute ()
		{
			return MyPrivateMethod1();
		}

		private string MyPrivateMethod1 ()
		{
			Console.WriteLine("call MyPrivateMethod1");
			return "MyPrivateMethod1";
		}
	}
}