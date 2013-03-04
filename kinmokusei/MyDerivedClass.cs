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

		public string CallBaseMethod()
		{
			return base.BaseMethod() + " & derived call base method";
		}
	}
}
