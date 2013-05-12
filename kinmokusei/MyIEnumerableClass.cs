using System;
using System.Collections;

namespace kinmokusei
{
	public class MyIEnumerableClass:IEnumerable
	{
		private string[] list;

		public MyIEnumerableClass (string[] args)
		{
			this.list=args;
		}
		public IEnumerator GetEnumerator()
		{
			return list.GetEnumerator();
		}
	}
}

