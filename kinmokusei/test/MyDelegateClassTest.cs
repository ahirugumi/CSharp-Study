using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace kinmokusei
{
	[TestFixture()]
	public class MyDelegateClassTest
	{
		[Test()]
		public void SimpleDelegateTestCase ()
		{
			MyDelegateClass my = new MyDelegateClass ();
			my.mydel = new MyDelegateClass.myDelegate(this.MyPrivateMethod1);
			Assert.AreEqual(my.Execute(),"MyPrivateMethod1");
			my.mydel = new MyDelegateClass.myDelegate(this.MyPrivateMethod2);
			Assert.AreEqual(my.Execute(),"MyPrivateMethod2");
			my.mydel = new MyDelegateClass.myDelegate(this.MyPrivateMethod3);
			Assert.AreEqual(my.Execute(),"MyPrivateMethod3");
		}

		private string MyPrivateMethod1 ()
		{
			Console.WriteLine("call MyPrivateMethod1");
			return "MyPrivateMethod1";
		}

		private string MyPrivateMethod2 ()
		{
			Console.WriteLine("call MyPrivateMethod2");
			return "MyPrivateMethod2";
		}

		private string MyPrivateMethod3 ()
		{
			Console.WriteLine("call MyPrivateMethod3");
			return "MyPrivateMethod3";
		}
	}
}

