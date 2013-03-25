using System;
using System.Collections.Generic;

namespace kinmokusei
{
	public class MyGenericPredicateDelegateClass
	{
		public MyGenericPredicateDelegateClass ()
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
			Predicate<string> pre = new Predicate<string>(BarSelector);
			return list.FindAll(pre);
		}

		public bool BarSelector (string args)
		{
			if (0 <= args.IndexOf ("bar")) 
			{
				return true;
			}
			else {
				return false;
			}
		}
	}
}

