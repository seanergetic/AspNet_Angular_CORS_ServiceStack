using System.Web.Optimization;

namespace Site
{
    public class BundleConfig
    {
         public static void RegisterBundles(BundleCollection bundles)
         {
             bundles.Add(new ScriptBundle("~/libs")
                 .Include("~/scripts/angular.js")
                 .Include("~/scripts/angular-resource.js"));
             bundles.Add(new ScriptBundle("~/app").IncludeDirectory("~/scripts/app", "*.js", true));
         }
    }
}