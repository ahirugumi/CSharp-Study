using System;
using NUnit.Framework;
using kinmokusei;

namespace kinmokusei
{
	[TestFixture()]
	public class KinmokuseiTest
	{
		private MyClass my=null;
		
		[SetUp()]
		public  void forSampleTest ()
		{
			my=new MyClass();
		}
		
		[Test()]
		public void IfSampleTest ()
		{
			Assert.AreEqual(my.IfSample(1),"1");
			Assert.AreEqual(my.IfSample(2),"2");
			Assert.AreEqual(my.IfSample(3),"3");
			Assert.AreEqual(my.IfSample(99),"0");
		}    
		
		[Test()]
		public void If3SampleTest ()
		{
			Assert.AreEqual(my.If3Sample(1),"1");
			Assert.AreEqual(my.If3Sample(2),"2");
		}    
		
		[Test()]
		public void SwitchSampleTest ()
		{
			Assert.AreEqual(my.SwitchSample(1),"1");
			Assert.AreEqual(my.SwitchSample(2),"2");
			Assert.AreEqual(my.SwitchSample(3),"3");
			Assert.AreEqual(my.SwitchSample(99),"0");
		}
		
		[Test()]
		public void ForSampleTest ()
		{
			Assert.AreEqual(my.ForSample(10),55);
		}
		
		[Test()]
		public void ForEachSampleTest ()
		{
			int[] args ={1,2,3,4,5,6,7,8,9,10};
			Assert.AreEqual(my.ForEachSample(args),55);
		}
		
		[Test()]
		public void WhileSampleTest ()
		{
			int[] args ={1,2,3,4,5,6,7,8,9,10};
			Assert.AreEqual(my.WhileSample(args),55);
		}
	}
}