namespace Sitecore.Support.Publishing
{
  using Sitecore.Caching;
  using Sitecore.Configuration;
  using Sitecore.Diagnostics;
  using Sitecore.Publishing.Pipelines.PublishItem;
  using Sitecore.Sites;
  using System;
  using System.Collections;
  using System.Web;


  public class AccessResultCacheClearer
  {
    /// <summary>
    /// Clears the AccessResult cache.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="args">The arguments.</param>
    public void ClearCache(object sender, EventArgs args)
    {
      Assert.ArgumentNotNull(sender, "sender");
      Assert.ArgumentNotNull(args, "args");
      Log.Info("AccessResultCacheClearer clearing AccessResult cache", this);
      AccessResultCache arcache = CacheManager.GetAccessResultCache();
      if(arcache!= null)
      {
        Log.Info("AccessResultCache is not empty. Size: " + arcache.InnerCache.Size, this);
        arcache.Clear();
      }
      Log.Info("AccessResultCacheClearer done.", this);
    }

  }
}