using System;

namespace kinmokusei
{
	public class Main
	{
		public Main ()
		{
		}
		public static void main ()
		{
			try {
				MyExceptionClass my = new MyExceptionClass();
				my.ExecuteThrowOnlyException();
			} catch (Exception ex) {
				Console.WriteLine(ex.ToString());				
			}
		}
	}
}

