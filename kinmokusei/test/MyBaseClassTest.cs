using System;
using NUnit.Framework;
using kinmokusei;

namespace kinmokusei
{
	[TestFixture()]
	public class MyBaseClassTest
	{
		[Test()]
		public void StaticConstructorTest()
		{
			new MyBaseClass();
			new MyBaseClass();
			new MyBaseClass();
		}
		[Test()]
		public void BaseMethodTest()
		{
			Assert.AreEqual(new MyBaseClass().BaseMethod(),"base method called"); 
		}
		[Test()]
		public void BaseNewMethodTest()
		{
			Assert.AreEqual(new MyBaseClass().BaseNewMethod(),"base new method called"); 
		} 
	}
}