using System;
using System.Collections.Generic;
using System.Linq;

namespace kinmokusei
{
	public class MyBasicLINQ
	{
		public MyBasicLINQ ()
		{
		}

		public IEnumerable<string> GetSimpleQuery(){
			string[] words= {"foo","bar","baz","hoge","moge","piyo"};
			var query = words.Where((x) => x.Contains("b"))
							.Select((x) => x)
							.OrderByDescending((x) => x);
			return query;
		}
	}
}