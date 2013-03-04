using System;

namespace kinmokusei
{
	public class MyAbstractDerivedClass  : MyAbstractClass
	{
		public MyAbstractDerivedClass ()
		{
		}

		public override string AbstractMethod ()
		{
			return "override abstract method";
		}
	}
}

