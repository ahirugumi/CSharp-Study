using System;

namespace kinmokusei
{
	public class MySubClass2:MyDelegateAbstractClass
	{
		public MySubClass2 ()
		{
		}

		public override string Execute ()
		{
			return MyPrivateMethod2();
		}

		private string MyPrivateMethod2 ()
		{
			Console.WriteLine("call MyPrivateMethod2");
			return "MyPrivateMethod2";
		}
	}
}

