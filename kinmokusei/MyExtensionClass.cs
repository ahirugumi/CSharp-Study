using System;

namespace kinmokusei
{
	internal static class MyExtensionClass
	{

		internal static string PrintingAndReturn(this string args){
			Console.WriteLine(args);
			return "OK:" + args;
		}
	}
}

