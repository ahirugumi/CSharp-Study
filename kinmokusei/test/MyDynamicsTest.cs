using System;
using NUnit.Framework;

namespace kinmokusei
{
	[TestFixture()]
	public class MyDynamicsTest
	{
		[Test()]
		public void ExecuteTestCase ()
		{
			Console.WriteLine(Execute ((dynamic)new Hoge()));
			Console.WriteLine(Execute ((dynamic)new Piyo()));
			Console.WriteLine(Execute ((dynamic)new MyDynamics()));
		}

		private static string Execute(dynamic args)
		{
			return args.Execute ();
		}
	}
}

