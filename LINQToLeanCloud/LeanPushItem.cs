using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;


namespace LINQToLeanCloud
{
	public class LeanPushItem
	{
		public LeanPushItem ()
		{
			
		}

		public string ObjectId{ get; set;}

		public	List<PushPlatform> Platforms{ get; set; }

		public Dictionary<string,string> NavigatePages{ get; set; }

		public string Title{ get; set;}

		public string Content{ get; set; }
	}

	public enum PushPlatform:int
	{
		iOS,
		Android,
		Windows,
		Web
	}

	public struct LeanPushConfig
	{
		public string TableName{ get; set; }

		public string TitleRow{ get; set; }

		public string ContentRow{ get; set; }

		public string NavigatePageRow{ get; set; }


	}
}

