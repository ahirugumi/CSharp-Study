using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Collections;

namespace kinmokusei
{
	[TestFixture()]
	public class MyBasicListTest
	{
		MyBasicList mylist;

		[SetUp]
		public void Setup ()
		{
			mylist = new MyBasicList();
		}

		[Test()]
		public void FirstBasicTest()
		{
			Assert.AreEqual(1,mylist.mylist0[0]);
			Assert.AreEqual(2,mylist.mylist0[1]);
			Assert.AreEqual(3,mylist.mylist0[2]);

			Assert.AreEqual("foo",mylist.mylist1[0]);
			Assert.AreEqual("bar",mylist.mylist1[1]);
			Assert.AreEqual("baz",mylist.mylist1[2]);

			string[] findAllList = mylist.findAllFilter();
			Assert.AreEqual("bar",findAllList[0]);
			Assert.AreEqual("baz",findAllList[1]);

			string[] copyList = new string[findAllList.Length]; 
			findAllList.CopyTo(findAllList,0);
			copyList[0]="hoge";
			Assert.AreEqual("hoge",copyList[0]);
			Assert.AreEqual("bar",findAllList[0]);
		}

		[Test()]
		public void ArrayListTest ()
		{
			List<string> normalList = mylist.GetNormalList();
			Assert.AreEqual("hoge",normalList[0]);
			Assert.AreEqual("moge",normalList[1]);
			Assert.AreEqual("piyo",normalList[2]);
		}

		[Test()]
		public void IndexerTest ()
		{
			MyIndexer myindexer = new MyIndexer("01234");
			Assert.AreEqual(0,myindexer[0]);
			Assert.AreEqual(1,myindexer[1]);
			Assert.AreEqual(2,myindexer[2]);
			Assert.AreEqual(3,myindexer[3]);
			Assert.AreEqual(4,myindexer[4]);
		}

		[Test()]
		public void EnumerableTest ()
		{
			string checkValue=string.Empty;
			IEnumerable ienumerable = new MyIEnumerableClass(new string[]{"foo","baz","bar"});
			foreach (var item in ienumerable) {
				checkValue+=item;
			}
			Assert.AreEqual(checkValue,"foobazbar");
		}

		[Test()]
		public void YieldTest ()
		{
			string checkValue=string.Empty;
			MyYieldClass ienumerable = new MyYieldClass(new string[]{"foo","baz","bar","moge","hoge"});
			foreach (var item in ienumerable) {
				checkValue+=item;
				Console.WriteLine("Test foreach:" + item);
			}
			Assert.AreEqual(checkValue,"yield:1:fooyield:2:bazyield:3:baryield:4:mogeyield:5:hoge");
		}
	}
}

