using System;
using System.Collections.Generic;

namespace kinmokusei
{
	public class MyBasicList
	{
		public int[] mylist0={1,2,3};
		public string[] mylist1=new string[]
		{
			"foo",
			"bar",
			"baz"
		};

		public string[] findAllFilter()
		{
			return Array.FindAll(mylist1,val=>BSelector(val,"b"));
		}

		public List<string> GetNormalList ()
		{
			List<string> list=new List<string>();
			list.Add("hoge");
			list.Add("moge");
			list.Add("piyo");
			return list;
		}

		private bool BSelector (string target,string filter)
		{
			if (0 <= target.IndexOf (filter)) 
			{
				return true;
			}
			else {
				return false;
			}
		}
	}
}

