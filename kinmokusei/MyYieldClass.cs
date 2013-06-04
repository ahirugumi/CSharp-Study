using System;
using System.Collections;

namespace kinmokusei
{
	public class MyYieldClass
	{

		private string[] list;
		public MyYieldClass (string[] args)
		{
			this.list=args;
		}

		public IEnumerator GetEnumerator()
		{
			Console.WriteLine("GetEnumerator");
			yield return "yield:1:"+list[0];
			yield return "yield:2:"+list[1];
			yield return "yield:3:"+list[2];
			yield return "yield:4:"+list[3];
			yield return "yield:5:"+list[4];
		}
	}
}

