using System;

namespace kinmokusei
{
	public class MyGenericActionDelegateClass
	{
		public Action<int,string> action;
		public MyGenericActionDelegateClass ()
		{
		}
		public void execute(int arg1, string arg2)
		{
			if (action != null) {
				action (arg1,arg2);
			}
		}
	}
}

