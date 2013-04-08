using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace kinmokusei
{
	[TestFixture()]
	public class MyAnonymousDelegateClassTest
	{
		[Test()]
		public void MyAnonymousDelegateTest ()
		{
			MyAnonymousDelegateClass my = new MyAnonymousDelegateClass();
			List<string> list = my.Execute();
			Assert.AreEqual(2, list.Count); 
			Assert.AreEqual("bar", list[0]); 
			Assert.AreEqual("hoge bar", list[1]); 
		}
	}
}

