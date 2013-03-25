using System;
using NUnit.Framework;

namespace kinmokusei
{
	[TestFixture()]
	public class MySubClassTest
	{
		[Test()]
		public void SimpleSublassTest ()
		{
			Assert.AreEqual (factorySubClass(1).Execute (), "MyPrivateMethod1");
			Assert.AreEqual (factorySubClass(2).Execute (), "MyPrivateMethod2");
			Assert.AreEqual (factorySubClass(3).Execute (), "MyPrivateMethod3");
		}

		private MyDelegateAbstractClass factorySubClass (int i)
		{
			switch (i) {
			case 1: 
				return new MySubClass1 ();
			case 2:
				return new MySubClass2 ();
			case 3:
				return new MySubClass3 ();
			default:
				return null;
			}
		}
	}
}

