using System;

namespace kinmokusei
{
	public class MyBazClass : IMyFooInterface,IMyBarInterface
	{
		public MyBazClass ()
		{
		}

		public string GetText()
		{
			return "baz";
		}

		string IMyFooInterface.GetText()
		{
			return "foo";
		}

		string IMyFooInterface.GetName()
		{
			return "Name is foo";
		}

		string IMyBarInterface.GetText()
		{
			return "bar";
		}
	}
}

