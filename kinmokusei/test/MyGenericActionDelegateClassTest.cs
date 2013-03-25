using System;
using NUnit.Framework;

namespace kinmokusei
{
	[TestFixture()]
	public class MyGenericActionDelegateClassTest
	{
		[Test()]
		public void MyGenericActionDelegateTest ()
		{
			MyGenericActionDelegateClass my = new MyGenericActionDelegateClass();
			my.action=MyPrivateMethod1;
			my.execute(100,"Test100");
			my.action=MyPrivateMethod2;
			my.execute(200,"Test200");
			my.action=MyPrivateMethod3;
			my.execute(300,"Test300");
		}
		private void MyPrivateMethod1 (int arg1,string arg2)
		{
			Console.WriteLine("call MyPrivateMethod1 arg1:{0} arg2:{1}",arg1,arg2);
		}
		
		private void MyPrivateMethod2 (int arg1,string arg2)
		{
			Console.WriteLine("call MyPrivateMethod2 arg1:{0} arg2:{1}",arg1,arg2);
		}
		
		private void MyPrivateMethod3 (int arg1,string arg2)
		{
			Console.WriteLine("call MyPrivateMethod3 arg1:{0} arg2:{1}",arg1,arg2);
		}
	}
}

