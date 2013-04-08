using System;

namespace kinmokusei
{
	// event send class
	public delegate void FooEventHandler(object sender, EventArgs e);
	public class MyEventHandler
	{
		public event FooEventHandler fooEvent;

		public void Execute ()
		{
			fooEvent(this,EventArgs.Empty);
		}
	}
}

