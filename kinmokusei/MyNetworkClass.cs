using System;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;

namespace kinmokusei
{
	public class MyNetworkClass
	{
		public MyNetworkClass ()
		{
		}

		public XDocument MyFeed { get; set; } 

		public void MyWebClient()
		{
			WebClient webClient = new WebClient ();
			Stream feed = webClient.OpenRead ("http://kinmokusei.sakura.ne.jp/doc/?feed=rss2");
			MyFeed = XDocument.Load(feed);
		}

		public string GetMyTitle()
		{
			var query = (from ret in MyFeed.Descendants ("channel")
					select ret).Single();
			return query.Element("title").Value;
		}

		public string GetHttpResponseString()
		{
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create ("http://ahirugumi.net/hiki/");
			using (HttpWebResponse resp=(HttpWebResponse)req.GetResponse())
			using (Stream st=resp.GetResponseStream())
			using (StreamReader reader=new StreamReader(st)) {
				string contents = reader.ReadToEnd ();
				return contents;
			}
		}
	}
}

