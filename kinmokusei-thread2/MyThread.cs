using System;
using System.Threading;

namespace kinmokusei
{
	public class MyThread
	{
		bool done; //share
		public static void Main (string[] args)
		{
			MyThread my = new MyThread ();
			var thread1 = new Thread(my.ThreadMethod);
			thread1.Start();
			my.ThreadMethod();
		}

		void ThreadMethod()
		{
			if (!done) {
				done = true;
				Console.WriteLine ("Done");
			}
		}
	}

}

