using System;
using NUnit.Framework;

namespace kinmokusei
{
	[TestFixture()]
	public class MyEventHandlerTest
	{
		[Test()]
		public void SingleEventHandlerTestCase ()
		{
			MyEventHandler target = new MyEventHandler ();
			target.fooEvent += new FooEventHandler (this.handler);
			target.Execute();
		}

		[Test()]
		public void MultiEventHandlerTestCase ()
		{
			MyEventHandler target = new MyEventHandler ();
			target.fooEvent += new FooEventHandler (this.handler);
			target.fooEvent += new FooEventHandler (this.handler);
			target.fooEvent += new FooEventHandler (this.handler);
			target.Execute();
		}

		private void handler( object o, EventArgs e )
		{
			Console.WriteLine("handler called");
		}
	}
}

