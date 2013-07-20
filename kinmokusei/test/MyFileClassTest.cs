using System;
using NUnit.Framework;
using System.IO;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Text;

namespace kinmokusei
{
	[TestFixture()]
	public class MyFileClassTest
	{
		[Test()]
		public void FileListTestCase ()
		{
			IEnumerable<string> files
				= Directory.EnumerateFiles (
					@"/Users/tomohiro/gitrepo/study/CSharp-Study/kinmokusei/",
					"*.cs",
					SearchOption.AllDirectories); // サブ・ディレクトも含める
			foreach (string file in files) { 
				Console.WriteLine (file); 
			}
		}

		[Test()]
		public void CreateAllTextFileTestCase ()
		{
			File.WriteAllText (@"/Users/tomohiro/gitrepo/study/CSharp-Study/kinmokusei/WriteAllText.txt", @"hoge
foo
bar
baz");

			Assert.AreEqual (@"hoge
foo
bar
baz", File.ReadAllText (@"/Users/tomohiro/gitrepo/study/CSharp-Study/kinmokusei/WriteAllText.txt"));
		}

		[Test()]
		public void CreateStreamWriterTestCase ()
		{
			using (StreamWriter writer = File.CreateText(@"/Users/tomohiro/gitrepo/study/CSharp-Study/kinmokusei/StreamWriter.txt")) {
				writer.WriteLine ("hoge");
				writer.WriteLine ("foo");
				writer.WriteLine ("bar");
				writer.WriteLine ("baz");
			}
			string text = "";
			foreach (var line in File.ReadLines(@"/Users/tomohiro/gitrepo/study/CSharp-Study/kinmokusei/WriteAllText.txt")) {
				text += line;
			}
			Assert.AreEqual (@"hogefoobarbaz", text);
		}

		[Test()]
		public void IsolatedStorageWriteReadTestCase ()
		{
			IsolatedStorageFile isoWriter =
				IsolatedStorageFile.GetUserStoreForDomain ();
			IsolatedStorageFileStream isoWriterStream =
				new IsolatedStorageFileStream (
					@"IsolatedStorageWriter.txt",
					FileMode.OpenOrCreate,
					FileAccess.Write,
					isoWriter);
			using (StreamWriter writer = new StreamWriter(isoWriterStream)) {
				writer.WriteLine ("moge");
			}
			isoWriterStream.Close ();
			isoWriter.Dispose ();

			IsolatedStorageFile isoReader =
				IsolatedStorageFile.GetUserStoreForDomain ();
			IsolatedStorageFileStream isoReaderStream =
				new IsolatedStorageFileStream (
					"IsolatedStorageWriter.txt",
					FileMode.Open,
					FileAccess.Read,
					isoReader);

			using (StreamReader reader = new StreamReader(isoReaderStream)) {
				Assert.AreEqual (reader.ReadLine (), "moge");
			}
			isoReaderStream.Close ();
			isoReader.Dispose ();
		}

		private AsyncCallback myCallBack;
		private byte[] buffer;
		const int BufferSize = 128;
		private Stream isoReaderStreamCallBack;

		[Test()]
		public void AsyncFileReadTestCase ()
		{
			buffer = new Byte[BufferSize];
			myCallBack = new AsyncCallback(this.OnCompletedRead);
			isoReaderStreamCallBack = File.OpenRead(@"/Users/tomohiro/gitrepo/study/CSharp-Study/kinmokusei/AsyncText.txt");
			isoReaderStreamCallBack.BeginRead( // 非同期読み込み
			                      buffer, // 読み込み結果を格納するバッファ
			                      0, // 読み込みの始点
			                      buffer.Length, // バッファのサイズ
			                      myCallBack, // 読み込み完了時のコールバック
			                      null // 状態を取得するためのオブジェクト
			                      );
			for( int i = 0; i < 100; i++ ) Console.WriteLine("i={0}", i);
			isoReaderStreamCallBack.Close ();
		}
		private void OnCompletedRead(IAsyncResult asyncResult)
		{
			int bytesRead = isoReaderStreamCallBack.EndRead(asyncResult);
			if( bytesRead > 0 )
			{
				String s = Encoding.ASCII.GetString(buffer, 0, bytesRead);
				Console.WriteLine("buffer={0}", s);
				isoReaderStreamCallBack.BeginRead(buffer, 0, buffer.Length, myCallBack, null);
			}
		}
	}
}