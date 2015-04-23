using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;


namespace LINQToLeanCloud
{
	public class LeanPushContext
	{
		internal LeanPushContext (string appId,string  appKey)
		{
			this.appId = appId;
			this.appKey = appKey;
			
		}

		private string appId;
		private string appKey;


		public IQueryable<LeanPushItem> PushCollections{ get; set;}
	}


}

