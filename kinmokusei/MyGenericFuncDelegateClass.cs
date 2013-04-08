using System;

namespace kinmokusei
{
	public class MyGenericFuncDelegateClass
	{
		public MyGenericFuncDelegateClass ()
		{
		}

		public string Execute ()
		{
			Func<string, string> convertMethod = UppercaseString;
			return convertMethod("foo");
		}

		private string UppercaseString(string args)
		{
			return args.ToUpper();
		}
	}
}

