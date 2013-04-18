using System;
using System.Runtime.Serialization;

namespace kinmokusei
{
	public class MyCustomException:Exception
	{
		public int Id { get; private set; }
		public string ErrorMessage { get; private set; }

		public MyCustomException ()
		{
		}
		
		public MyCustomException (string message)
			: base(message)
		{
			this.ErrorMessage=message;
		}

		public MyCustomException (string message, Exception innerException)
			: base(message,  innerException)
		{
			this.ErrorMessage=message;
		}

		public MyCustomException(SerializationInfo info,StreamingContext context)
			:base(info,context)
		{
		}

		public MyCustomException (int id, string message)
		{
			this.Id=id;
			this.ErrorMessage=message;
		}
	}
}

