using System;
using NUnit.Framework;

namespace kinmokusei
{
	[TestFixture()]
	public class MyBazClassTest
	{
		[Test()]
		public void FooBarInterfaceTest()
		{
			IMyFooInterface foo = new MyBazClass();
			IMyBarInterface bar = new MyBazClass();
			MyBazClass baz = new MyBazClass();

			Assert.AreEqual(foo.GetText(),"foo"); 
			Assert.AreEqual(foo.GetName(),"Name is foo"); 
			Assert.AreEqual(bar.GetText(),"bar"); 
			//complie error
			//Assert.AreEqual(bar.GetName(),"bar"); 
			Assert.AreEqual(baz.GetText(),"baz"); 
		}
	}
}

