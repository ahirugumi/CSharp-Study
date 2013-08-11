using System;
using System.Net.Sockets;
using System.Text;

namespace kinmokusei
{
	public class MySocketClient
	{
		public static void Main (string[] args)
		{
			//Create Client
			TcpClient client = new TcpClient ("192.168.24.55", 8888);
			try {
				byte[] tmp = Encoding.Unicode.GetBytes ("Hello World");
				NetworkStream stream = client.GetStream (); 
				//send "Hello world"
				stream.Write (tmp, 0, tmp.Length);
			} finally {
				client.Close ();
			}
		}
	}
}