using System;
using System.Threading;

namespace kinmokusei
{
	public class MyThread
	{
		static bool done; //share
		static readonly object mylock = new object();
		public static void Main (string[] args)
		{
			var thread1 = new Thread(ThreadMethod);
			thread1.Start();
			ThreadMethod();
		}

		static void ThreadMethod()
		{
			lock (mylock) {
				if (!done) {
					Console.WriteLine ("Done");
					done = true;
				}
			}
		}
	}
}
