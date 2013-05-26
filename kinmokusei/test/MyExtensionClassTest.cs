using System;
using NUnit.Framework;

namespace kinmokusei
{
	[TestFixture()]
	public class MyExtensionClassTest
	{
		[Test()]
		public void PrintingTestCase ()
		{
			Assert.AreEqual("Test Extension Method!".PrintingAndReturn(),"OK:Test Extension Method!");
		}
	}
}

