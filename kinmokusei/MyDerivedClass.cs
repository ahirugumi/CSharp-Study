using System;

namespace kinmokusei
{
	public class MyDerivedClass : MyBaseClass
	{
		public MyDerivedClass ()
		{
		}

		public override string BaseVirtualMethod()
		{
			return "base virtual method override"; 
		}
	}
}
