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
	}
}