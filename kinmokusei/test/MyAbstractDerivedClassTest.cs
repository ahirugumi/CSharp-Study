using System;
using NUnit.Framework;

namespace kinmokusei
{
	[TestFixture()]
	public class MyAbstractDerivedClassTest
	{
		[Test()]
		public void AbstractMethodTest()
		{
			Assert.AreEqual(new MyAbstractDerivedClass().AbstractMethod(),"override abstract method"); 
		}
	}
}

