using System.Web;
using System.Web.Optimization;

namespace syseng_back.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/mail").Include(
                      "~/Content/js/email.js"));

            bundles.Add(new StyleBundle("~/Content/core").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/css/master.css"));

            bundles.Add(new StyleBundle("~/Content/index").Include(
                      "~/Content/css/index-page.css"));

            bundles.Add(new StyleBundle("~/Content/articles").Include(
                      "~/Content/css/articles-page.css"));

            bundles.Add(new StyleBundle("~/Content/automation").Include(
                      "~/Content/css/automation-page.css"));

            bundles.Add(new StyleBundle("~/Content/waterclean").Include(
                      "~/Content/css/water-page.css"));

            bundles.Add(new StyleBundle("~/Content/cotnact").Include(
                      "~/Content/css/contact-page.css"));
        }
    }
}
