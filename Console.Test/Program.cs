using System;
using LINQToLeanCloud;

namespace Test.Demo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			LeanCloudContext LeanCloud = new LeanCloudContext ("appId","appKey");

			var pushCtx = LeanCloud.GetPushContext ();


			
			Console.WriteLine ("Hello World!");
		}
	}
}
