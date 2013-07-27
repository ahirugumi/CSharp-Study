using System;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace kinmokusei
{
	public class MyXMLList
	{
		public string Id{ get; set; }

		public string Name{ get; set; }

		public string Mail{ get; set; }

		public override string ToString ()
		{
			return string.Format("Id -> {0}, Name -> {1}, Mail -> {2}",this.Id,this.Name,this.Mail);
		}
	}

	public class MyXMLClass
	{
		public MyXMLClass ()
		{
		}

		public XDocument GetXMLDocument ()
		{
			var myxml = new XDocument ();
			var myele = new XElement ("myxmls");

			var ele100 = new XElement ("myxml");
			var idele100 = new XElement ("id", "100");
			var nameele100 = new XElement ("name", "hoge");
			var mailatt100 = new XAttribute ("mail", "hoge@gmail.com");
			myele.Add (ele100);
			ele100.Add (idele100);
			nameele100.Add (mailatt100);
			ele100.Add (nameele100);

			var ele200 = new XElement ("myxml");
			var idele200 = new XElement ("id", "200");
			var nameele200 = new XElement ("name", "bar");
			var mailatt200 = new XAttribute ("mail", "bar@gmail.com");
			myele.Add (ele200);
			ele200.Add (idele200);
			nameele200.Add (mailatt200);
			ele200.Add (nameele200);

			var ele300 = new XElement ("myxml");
			var idele300 = new XElement ("id", "300");
			var nameele300 = new XElement ("name", "foo");
			var mailatt300 = new XAttribute ("mail", "foo@gmail.com");
			myele.Add (ele300);
			ele300.Add (idele300);
			nameele300.Add (mailatt300);
			ele300.Add (nameele300);

			myxml.Add (myele);
			return myxml;
		}

		static List<MyXMLList> GetMyList ()
		{
			List<MyXMLList> myXmlList = new List<MyXMLList> {
				new MyXMLList {
					Id = "100",
					Name = "hoge",
					Mail = "hoge@gmail.com"
				},
				new MyXMLList {
					Id = "200",
					Name = "bar",
					Mail = "bar@gmail.com"
				},
				new MyXMLList {
					Id = "300",
					Name = "foo",
					Mail = "foo@gmail.com"
				},
			};
			return myXmlList;
		}

		public XDocument GetListToXML ()
		{
			var myxml = new XDocument ();
			var myele = new XElement ("myxmls");
			var myXmlList = GetMyList ();

			foreach (MyXMLList mylist in myXmlList) {
				var ele = new XElement ("myxml");
				var idele = new XElement ("id", mylist.Id);
				var nameele = new XElement ("name", mylist.Name);
				var mailatt = new XAttribute ("mail", mylist.Mail);
				ele.Add (myele);
				myele.Add (idele);
				nameele.Add (mailatt);
				myele.Add (nameele);
			}
			return myxml;
		}

		public XDocument GetLINQToXML ()
		{
			var myXmlList = GetMyList ();
			var myxml = new XDocument (new XElement ("myxmls", 
			                                         from mylist in myXmlList
			                                       select new XElement ("myxml",
			                                                            new XElement ("id", mylist.Id),
			                                                            new XElement ("name", mylist.Name, 
			                                                                          new XAttribute ("mail", mylist.Mail)))));
			return myxml;
		}

		public XElement GetSearchElement ()
		{
			var myxml = GetLINQToXML ();
			var query = from ret in myxml.Descendants ("id")
					where ret.Value == "100" 
					select ret;
			return query.SingleOrDefault();
		}

		public XElement GetSearchAttribute ()
		{
			var myxml = GetLINQToXML ();
			var query = from ret in myxml.Element ("myxmls").Elements("myxml").Elements("name")
				where ret.Attribute("mail").Value == "foo@gmail.com" 
					select ret;
			return query.SingleOrDefault();
		}

		public string SerializeXML ()
		{
			XmlSerializer serializer = new XmlSerializer (typeof(List<MyXMLList>));
			var myXmlList = GetMyList ();
			StringWriter writer = new StringWriter ();
			serializer.Serialize (writer, myXmlList);
			return writer.ToString();
		}

		public List<MyXMLList> DeserializeXML ()
		{
			XmlSerializer serializer = new XmlSerializer (typeof(List<MyXMLList>));
			return (List<MyXMLList>)serializer.Deserialize(new StringReader(SerializeXML ()));
		}
	}
}

  