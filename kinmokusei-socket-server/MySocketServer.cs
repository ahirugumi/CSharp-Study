using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;

namespace kinmokusei
{
	public class MySocketServer
	{
		public static void Main (string[] args)
		{
			{
				//TCPListener Start
				TcpListener listener = new TcpListener (new IPEndPoint (IPAddress.Parse ("192.168.24.55"), 8888));
				listener.Start (0);
				Console.WriteLine ("TCP Listen Port:8888 Start");

				TcpClient client = listener.AcceptTcpClient ();
				Console.WriteLine ("Client Connect ... ");

				if (client.Connected) {
					listener.Stop ();
					StreamReader sReader = new StreamReader (client.GetStream (), Encoding.UTF8);
					string str = "";

					//read start
					do {
						str = sReader.ReadLine ();
						if (null == str) {
							break;
						}
						Console.WriteLine (str);
					} while (!str.Equals("quit"));
					sReader.Close ();
					client.Close ();
				}
				Console.WriteLine ("Please Enter ...");
				Console.ReadLine ();
			}
		}
	}
}
