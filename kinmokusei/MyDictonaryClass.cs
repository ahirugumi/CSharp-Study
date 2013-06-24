using System;
using System.Collections.Generic;

namespace kinmokusei
{
	public class MyDictonaryClass
	{
		public MyDictonaryClass ()
		{
		}

		public Dictionary<int, String> getMyDictonary()
		{
			Dictionary<int, String> dic = new Dictionary<int, String>();
			dic.Add(1, "BBB");
			dic.Add(2, "CCC");
			dic.Add(0, "AAA");
			return dic;
		}

		public HashSet<String> getMyHashSet()
		{
			HashSet<String> dic = new HashSet<String>();
			dic.Add("AAA");
			dic.Add("BBB");
			dic.Add("CCC");
			return dic;
		}

		public Queue<String> getMyQueue()
		{
			Queue<String> que = new Queue<String> ();
			que.Enqueue("CCC");
			que.Enqueue("BBB");
			que.Enqueue("AAA");
			return que;
		}

		public LinkedList<String> getMyLinkedList()
		{
			LinkedList<String> link = new LinkedList<String> ();
			link.AddFirst ("CCC");
			link.AddLast ("AAA");
			link.AddFirst ("BBB");
			return link;
		}

		public Stack<String> getMyStack()
		{
			Stack<String> stack = new Stack<String> ();
			stack.Push ("AAA");
			stack.Push ("BBB");
			stack.Push ("CCC");
			return stack;
		}
	}
}

