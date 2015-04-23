using System;

namespace LINQToLeanCloud
{
	public class LeanCloudContext
	{
		public LeanCloudContext (string appId,string appKey)
		{
			Initialize (appId, appKey);
		}

		public LeanPushContext GetPushContext()
		{
			return new LeanPushContext (AppId, AppKey);
		}

		public static string  AppId{ get; set;}

		public static string  AppKey{ get; set;}

		public static void Initialize(string appId,string appKey)
		{
			LeanCloudContext.AppId = appId;
			LeanCloudContext.AppKey = AppKey;
		}
	}
}

