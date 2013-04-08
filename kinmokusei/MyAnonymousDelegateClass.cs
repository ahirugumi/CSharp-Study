using System;
using System.Collections.Generic;

namespace kinmokusei
{
	public class MyAnonymousDelegateClass
	{
		public MyAnonymousDelegateClass ()
		{
		}

		public List<string> Execute ()
		{
			List<string> list = new List<string>();
			list.Add("foo");
			list.Add("bar");
			list.Add("baz");
			list.Add("piyo");
			list.Add("hoge bar");
			return list.FindAll(
				delegate(string args)
				{
				if (0 <= args.IndexOf ("bar")) 
				{
					return true;
				}
				else {
					return false;
				}
			});
		}
	}
}

