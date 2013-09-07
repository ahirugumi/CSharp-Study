using System;
using NUnit.Framework;

namespace kinmokusei
{
	[TestFixture()]
	public class MyDatabaseClassTest
	{
		[Test()]
		public void MyDatabaseClassTestCase ()
		{
			MyDatabaseClass db = new MyDatabaseClass ();
			Assert.AreEqual(db.GetMyTable (),"piyo,test_comment");
		}
	}
}

