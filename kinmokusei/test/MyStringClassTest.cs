using System;
using NUnit.Framework;
using System.Globalization;
using System.Threading;

namespace kinmokusei
{
	[TestFixture()]
	public class MyStringClassTest
	{
		[Test()]
		public void GetQuotedHereTest ()
		{
			MyStringClass my = new MyStringClass ();
			Assert.AreEqual (my.getQuoted (), "C:\\hoge\\piyo\\bar");
			Assert.AreEqual (my.getHere (), "bar\nfoo\nbaz\n");
		}

		[Test()]
		public void NumberFormatTest ()
		{
			Assert.AreEqual ("0123.4560", 123.456.ToString ("0000.0000"));
			Assert.AreEqual ("123.456", 123.456.ToString ("####.####"));

			Assert.AreEqual ("123,456,789", 123456789.ToString ("#,#"));
			Assert.AreEqual ("09", 9.ToString ("0,0"));

			Assert.AreEqual ("77%", 0.77.ToString ("#,#%"));

			Assert.AreEqual ("123,457", 123456789.ToString ("#,#,."));
		}

		[Test()]
		public void DateFormatTest ()
		{
			DateTime mydate = new DateTime (2013, 07, 01, 13, 11, 53, 34);
			Assert.AreEqual (mydate.ToString ("d"), "2013/07/01");
			Assert.AreEqual (mydate.ToShortDateString (), "2013/07/01");
			Assert.AreEqual (mydate.ToString ("t"), "13:11");
			Assert.AreEqual (mydate.ToShortTimeString (), "13:11");
			Assert.AreEqual (mydate.ToString ("T"), "13:11:53");
			Assert.AreEqual (mydate.ToLongTimeString (), "13:11:53");
			Assert.AreEqual (mydate.ToString ("yyyy"), "2013");
			Assert.AreEqual (mydate.ToString ("dd"), "01");
			Assert.AreEqual (mydate.ToString ("MM"), "07");
			Assert.AreEqual (mydate.ToString ("HH"), "13");
			Assert.AreEqual (mydate.ToString ("mm"), "11");
			Assert.AreEqual (mydate.ToString ("ss"), "53");
		}

		[Test()]
		public void ConvertTest ()
		{
			Assert.AreEqual (Convert.ToInt32(12),12);
			Assert.AreEqual (Convert.ToString(12),"12");
			Assert.AreEqual (Convert.ToDateTime("2013/07/01 13:11:53.034"),new DateTime(2013,07,01,13,11,53,034));
		}

		[Test()]
		public void TryParseTest ()
		{
			double myDouble;
			if (double.TryParse ("12345.67", out myDouble)) {
				Assert.AreEqual (12345.67,myDouble);
			} else {
				Assert.Fail();
			}
		}

		[Test()]
		public void StringFormatTest ()
		{
			Assert.AreEqual (String.Format("{0},{1},{2}","foo","bar","baz"),"foo,bar,baz");
		}

		[Test()]
		public void CultureTest ()
		{
			Assert.AreEqual (CultureInfo.CurrentCulture.Name, "ja-JP");
			Assert.AreEqual (Thread.CurrentThread.CurrentCulture.Name,"ja-JP");
			DateTime dateTime = new DateTime(2013, 7, 2);
			Assert.AreEqual (dateTime.ToShortDateString(), "2013/07/02");
			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
			Assert.AreEqual (dateTime.ToShortDateString(), "7/2/2013");
			Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
			Assert.AreEqual (dateTime.ToShortDateString(), "02.07.2013");
		}
	}
}

