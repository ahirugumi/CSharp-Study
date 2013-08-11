using System;
using NUnit.Framework;

namespace kinmokusei
{
	[TestFixture()]
	public class MyNetworkClassTest
	{
		private MyNetworkClass mynetwork=null;

		[SetUp]
		public void Init()
		{
			mynetwork = new MyNetworkClass ();
			mynetwork.MyWebClient ();
			Assert.AreNotEqual(mynetwork.MyFeed,null);
		}

		[Test()]
		public void GetAllContentsTestCase ()
		{
			Console.WriteLine(mynetwork.MyFeed.ToString());
		}

		[Test()]
		public void GetMyTitleTestCase ()
		{
			Assert.AreEqual(mynetwork.GetMyTitle (),"勉強団「きんもくせい」");
		}

		[Test()]
		public void GetHttpResponseStringTestCase ()
		{
			Assert.AreNotEqual(mynetwork.GetHttpResponseString(),null);
		}
	}
}

