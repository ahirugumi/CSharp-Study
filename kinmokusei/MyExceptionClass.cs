using System;

namespace kinmokusei
{
	public class MyExceptionClass
	{
		public MyExceptionClass ()
		{
		}
		public void Execute (int arg)
		{
			if (arg<0) {
				throw new InvalidOperationException("args is > 0");
			}
		}

		public void ExecuteInnerException (int arg)
		{
			try {
				this.Execute(arg);
			} catch (InvalidOperationException ex) {
				throw new InvalidProgramException("execute fail",ex);
			}
		}

		public void ExecuteThrowException (int arg)
		{
			try {
				this.Execute(arg);
			} catch (InvalidOperationException ex) {
				//not new wrapper
				throw ex;
			}
		}

		public void ExecuteThrowOnlyException (int arg)
		{
			try {
				this.Execute(arg);
			} catch (InvalidOperationException ex) {
				//not throw ex
				throw;
			}
		}
	}
}

