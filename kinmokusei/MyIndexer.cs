using System;

namespace kinmokusei
{
	public class MyIndexer
	{
		public MyIndexer ()
		{
		}
		private string mystring;
		
		public MyIndexer(string s)
		{
			mystring = s;
		}
		public int this[int index]
		{
			get
			{
				return Convert.ToInt16(mystring.Substring(index, 1));
			}
		}
	}
}

