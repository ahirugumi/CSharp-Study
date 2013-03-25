using System;

namespace kinmokusei
{
	public class MyDelegateClass
	{
		public delegate string myDelegate ();

		public myDelegate mydel;
		
		public string Execute ()
		{
			if (mydel != null) {
				return mydel ();
			}
			return "";
		}
	}
}

