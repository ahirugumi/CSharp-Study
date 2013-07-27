using System;
using NUnit.Framework;
using System.IO;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Text;

namespace kinmokusei
{
	[TestFixture()]
	public class MyXMLClassTest
	{
		[Test()]
		public void GetMyXMLTestCase ()
		{
			MyXMLClass myxml = new MyXMLClass ();
			var retxml = myxml.GetXMLDocument ();
			Assert.AreEqual (retxml.ToString(), @"<?xml version=""1.0"" encoding=""utf-16""?>
<myxmls>
  <myxml>
    <id>100</id>
    <name mail=""hoge@gmail.com"">hoge</name>
  </myxml>
  <myxml>
    <id>200</id>
    <name mail=""bar@gmail.com"">bar</name>
  </myxml>
  <myxml>
    <id>300</id>
    <name mail=""foo@gmail.com"">foo</name>
  </myxml>
</myxmls>");
		}

		[Test()]
		public void GetListToXMLTestCase ()
		{
			MyXMLClass myxml = new MyXMLClass ();
			var retxml = myxml.GetXMLDocument ();
			Assert.AreEqual (retxml.ToString(), @"<?xml version=""1.0"" encoding=""utf-16""?>
<myxmls>
  <myxml>
    <id>100</id>
    <name mail=""hoge@gmail.com"">hoge</name>
  </myxml>
  <myxml>
    <id>200</id>
    <name mail=""bar@gmail.com"">bar</name>
  </myxml>
  <myxml>
    <id>300</id>
    <name mail=""foo@gmail.com"">foo</name>
  </myxml>
</myxmls>");
		}

		[Test()]
		public void GetLINQToXMLTestCase ()
		{
			MyXMLClass myxml = new MyXMLClass ();
			var retxml = myxml.GetLINQToXML ();
			Assert.AreEqual (retxml.ToString(), @"<?xml version=""1.0"" encoding=""utf-16""?>
<myxmls>
  <myxml>
    <id>100</id>
    <name mail=""hoge@gmail.com"">hoge</name>
  </myxml>
  <myxml>
    <id>200</id>
    <name mail=""bar@gmail.com"">bar</name>
  </myxml>
  <myxml>
    <id>300</id>
    <name mail=""foo@gmail.com"">foo</name>
  </myxml>
</myxmls>");
		}

		[Test()]
		public void GetSearchElementTestCase ()
		{
			MyXMLClass myxml = new MyXMLClass ();
			var retxml = myxml.GetSearchElement ();
			Assert.AreEqual (retxml.ToString (), @"<id>100</id>");
		}

		[Test()]
		public void GetSearchAttributeTestCase ()
		{
			MyXMLClass myxml = new MyXMLClass ();
			var retxml = myxml.GetSearchAttribute ();
			Assert.AreEqual (retxml.ToString (), @"<name mail=""foo@gmail.com"">foo</name>");
		}

		[Test()]
		public void SerializeXMLTestCase ()
		{
			MyXMLClass myxml = new MyXMLClass ();
			var retxml = myxml.SerializeXML ();
			Assert.AreEqual (retxml, @"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfMyXMLList xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <MyXMLList>
    <Id>100</Id>
    <Name>hoge</Name>
    <Mail>hoge@gmail.com</Mail>
  </MyXMLList>
  <MyXMLList>
    <Id>200</Id>
    <Name>bar</Name>
    <Mail>bar@gmail.com</Mail>
  </MyXMLList>
  <MyXMLList>
    <Id>300</Id>
    <Name>foo</Name>
    <Mail>foo@gmail.com</Mail>
  </MyXMLList>
</ArrayOfMyXMLList>");
		}

		[Test()]
		public void DeserializeXMLTestCase ()
		{
			MyXMLClass myxml = new MyXMLClass ();
			var retxml = myxml.DeserializeXML ();
			Assert.IsInstanceOf<List<MyXMLList>> (retxml);
		}
	}
}