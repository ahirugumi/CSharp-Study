using System;

namespace kinmokusei
{
	public class MySubClass3:MyDelegateAbstractClass
	{
		public MySubClass3 ()
		{
		}

		public override string Execute ()
		{
			return MyPrivateMethod3();
		}

		private string MyPrivateMethod3 ()
		{
			Console.WriteLine("call MyPrivateMethod3");
			return "MyPrivateMethod3";
		}
	}
}

