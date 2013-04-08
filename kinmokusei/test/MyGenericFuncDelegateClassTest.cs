using System;
using NUnit.Framework;

namespace kinmokusei
{
	public class MyGenericFuncDelegateClassTest
	{
		public MyGenericFuncDelegateClassTest ()
		{
		}

		[Test()]
		public void MyGenericFuncDelegateTest ()
		{
			MyGenericFuncDelegateClass my = new MyGenericFuncDelegateClass();
			Assert.AreEqual("FOO", my.Execute()); 
		}
	}
}

