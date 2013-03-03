using System;

namespace kinmokusei
{
	public class MyBaseClass
	{
		static MyBaseClass ()
		{
			Console.WriteLine ("default static constructor called"); 
		}

		public string BaseMethod()
		{
			return "base method called"; 
		}

		//warning message desplayed 
		public new string BaseNewMethod ()
		{
			return "base new method called";
		}

		public virtual string BaseVirtualMethod()
		{
			return "base virtual method called";
		}
	}
}

