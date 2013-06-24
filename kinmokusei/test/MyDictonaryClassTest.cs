using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace kinmokusei
{
	[TestFixture()]
	public class MyDictonaryClassTest
	{
		[Test()]
		public void GetMyDictonaryTestCase ()
		{
			MyDictonaryClass mydic = new MyDictonaryClass();
			Dictionary<int, String> dic = mydic.getMyDictonary();
			Assert.AreEqual(dic[0],"AAA");
			Assert.AreEqual(dic[1],"BBB");
			Assert.AreEqual(dic[2],"CCC");
		}

		[Test()]
		public void LoopMyDictonaryTestCase ()
		{
			MyDictonaryClass mydic = new MyDictonaryClass();
			foreach (KeyValuePair<int, string> kvp in mydic.getMyDictonary()) {
				Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
			}
		}

		[Test()]
		public void LoopVarMyDictonaryTestCase ()
		{
			MyDictonaryClass mydic = new MyDictonaryClass();
			foreach (var kvp in mydic.getMyDictonary()) {
				Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
			}
		}

		[Test()]
		public void GetMyHashSetTestCase ()
		{
			MyDictonaryClass mydic = new MyDictonaryClass();
			HashSet<String> dic = mydic.getMyHashSet();
			foreach (var item in dic) {
				Console.WriteLine("{0}", item);
			}
		}

		[Test()]
		public void GetMyQueueTestCase ()
		{
			MyDictonaryClass mydic = new MyDictonaryClass();
			Queue<String> que = mydic.getMyQueue();
			Assert.AreEqual("CCC", que.Dequeue());
			Assert.AreEqual("BBB", que.Dequeue());
			Assert.AreEqual("AAA", que.Dequeue());
		}

		[Test()]
		public void GetMyLinkedListTestCase ()
		{
			MyDictonaryClass mydic = new MyDictonaryClass();
			LinkedList<String> link = mydic.getMyLinkedList();
			Assert.AreEqual("BBB", link.First.Value);
			Assert.AreEqual("CCC", link.First.Next.Value);
			Assert.AreEqual("AAA", link.Last.Value);
		}

		[Test()]
		public void GetMyStackTestCase ()
		{
			MyDictonaryClass mydic = new MyDictonaryClass();
			Stack<String> stack = mydic.getMyStack();
			Assert.AreEqual("CCC", stack.Pop());
			Assert.AreEqual("BBB", stack.Pop());
			Assert.AreEqual("AAA", stack.Pop());
		}
	}
}

