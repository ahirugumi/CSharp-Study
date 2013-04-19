using System;
using NUnit.Framework;

namespace kinmokusei
{
	[TestFixture()]
	public class MyExceptionClassTest
	{
		[Test()]
		public void ExecuteTestCase ()
		{
			try {
				MyExceptionClass my = new MyExceptionClass();
				my.Execute(-1);
				Assert.Fail("ExecuteTestCase fail");
			} catch (InvalidOperationException ex) {
				Assert.AreEqual(ex.Message,"args is > 0");
				Assert.IsNull(ex.InnerException);
			}
		}

		[Test()]
		public void ExecuteInnerExceptionTestCase ()
		{
			try {
				MyExceptionClass my = new MyExceptionClass();
				my.ExecuteInnerException(-1);
				Assert.Fail("ExecuteInnerExceptionTestCase fail");
			} catch (InvalidProgramException ex) {
				Assert.AreEqual(ex.Message,"execute fail");
				Assert.AreEqual(ex.InnerException.Message,"args is > 0");
			}
		}

		[Test()]
		public void ExecuteCustomExceptionTestCase ()
		{
			try {
				throw new MyCustomException(100,"file not found. check your directory.");
			} catch (MyCustomException ex) {
				//ex is innerexception=null
				Assert.AreEqual(ex.Id,100);
				Assert.AreEqual(ex.ErrorMessage,"file not found. check your directory.");
			}
		}
	}
}

