using System;
using NUnit.Framework;
using System.Collections;

namespace kinmokusei
{
	[TestFixture()]
	public class MyBasicLINQTest
	{
		MyBasicLINQ mylinq;

		[SetUp]
		public void Setup ()
		{
			mylinq = new MyBasicLINQ();
		}

		[Test()]
		public void GetSimpleQuery ()
		{
			string checkValue="";
			var ret = mylinq.GetSimpleQuery();
			foreach (var item in ret) {
				checkValue+=item;
			}
			Assert.AreEqual(checkValue,"bazbar");
		}
	}
}

