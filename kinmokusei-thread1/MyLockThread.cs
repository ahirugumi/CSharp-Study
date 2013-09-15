using System;
using System.Threading;

namespace kinmokusei
{
	public class MyThread
	{
		public static void Main (string[] args)
		{
			Thread thread1 = new Thread(
				new ThreadStart(ThreadMethod));

			thread1.Start();

			for(int i = 0; i < 10; i++)
			{
				Thread.Sleep(3);
				Console.WriteLine("main-thread");
			}	
		}

		private static void ThreadMethod()
		{
			for (int i = 0; i < 10; i++)
			{
				Thread.Sleep(5);
				Console.WriteLine("thread1");
			}
		}
	}
}

