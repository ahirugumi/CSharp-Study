using System;
using NUnit.Framework;
using kinmokusei;
 
namespace kinmokusei
{
	[TestFixture()]
	public class MyDerivedClassTest
	{
		private MyDerivedClass my=null;
		
		[SetUp()]
		public void MyDerivedTest ()
		{
			my=new MyDerivedClass();
		}
		 
		[Test()]
		public void BaseClassCallTest()
		{
			Assert.AreEqual(my.BaseMethod(),"base method called"); 
		}
		 
		[Test()]
		public void BaseMethodCallTest()
		{
			Assert.AreEqual(my.BaseMethod(),"base method called"); 
		}
		 
		[Test()]
		public void BaseNewMethodCallTest()
		{
			Assert.AreEqual(my.BaseNewMethod(),"base new method called"); 
		}
		 
		[Test()]
		public void BaseVirtualMethodCallTest()
		{
			Assert.AreEqual(my.BaseVirtualMethod(),"base virtual method override"); 
		}

		[Test()]
		public void CallBaseMethodTest()
		{
			Assert.AreEqual(my.CallBaseMethod(),"base method called & derived call base method" ); 
		}
	}
}

