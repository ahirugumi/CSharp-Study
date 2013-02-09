using System;

namespace kinmokusei
{
	public class MyClass
	{
		public String IfSample (int arg)
		{
			String result = "";
			if (arg == 1) {
				result = "1";
			} else if (arg == 2) {
				result = "2";
			} else if (arg == 3) {
				result = "3";
			} else {
				result = "0";
			}
			return result;
		}

		public String If3Sample (int arg)
		{
			return arg == 1 ? "1" : "2";
		}

		public String SwitchSample (int arg)
		{
			String result = "";
			switch (arg) {
			case 1:
				result = "1";
				break;
			case 2:
				result = "2";
				break;
			case 3:
				result = "3";
				break;
			default:
				result = "0";
				break;
			}
			return result;
		}

		public int ForSample (int arg)
		{
			int result = 0;
			for (int i = 0; i <= arg; i++) {
				result += i;
			}
			return result;
		}

		public int ForEachSample (int[] arg)
		{
			int result = 0;
			foreach (int item in arg) {
				result += item;
			}
			return result;
		}

		public int WhileSample (int[] arg)
		{
			int i = 0;
			int result = 0;
			while (arg.Length > i) {
				result += arg [i];
				i++;
			}
			return result;
		}
	}
}

