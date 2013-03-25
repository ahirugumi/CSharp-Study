using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace kinmokusei
{
	[TestFixture()]
	public class MyGenericPredicateDelegateClassTest
	{
		[Test()]
		public void MyGenericPredicateDelegateTest ()
		{
			MyGenericPredicateDelegateClass my = new MyGenericPredicateDelegateClass();
			List<string> list = my.Execute();
			Assert.AreEqual(2, list.Count); 
			Assert.AreEqual("bar", list[0]); 
			Assert.AreEqual("hoge bar", list[1]); 
		}
	}
}

