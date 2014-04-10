using System.Web;
using System.Web.Optimization;

namespace Southside2
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            //            "~/Scripts/jquery-ui-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.unobtrusive*",
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            // TODO: remove page-*.css
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                  "~/assets/css/typography.css"
                , "~/assets/css/style/global.css"
                , "~/assets/css/style/navigation.css"
                , "~/assets/css/style/page-home.css"
                , "~/assets/css/style/content.css"
                , "~/assets/css/style/forms.css"
                , "~/assets/css/style/footer.css"
                , "~/assets/css/style/google-map.css"
                , "~/assets/css/style/media-queries.css"
                , "~/assets/css/style/media-widget.css"
                , "~/assets/css/responsive-iframe.css"
                ));

        }
    }
}