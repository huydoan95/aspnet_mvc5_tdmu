using System.Web;
using System.Web.Optimization;

namespace TDMU
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Content/Client/js/jquery/jquery-2.1.4.min.js",
                        "~/Content/Client/js/bootstrap/bootstrap.min.js",
                        "~/Content/Client/js/bootflat/icheck.min.js",
                        "~/Content/Client/js/bootflat/jquery.fs.selecter.min.js",
                        "~/Content/Client/js/bootflat/jquery.fs.stepper.min.js",
                        "~/Content/Client/js/revslider/js/jquery.themepunch.plugins.min.js",
                        "~/Content/Client/js/revslider/js/jquery.themepunch.revolution.min.js",
                        "~/Content/Client/js/flexslider/jquery.flexslider-min.js",
                        "~/Content/Client/js/slick/slick.min.js",
                        "~/Content/Client/js/succinct/jQuery.succinct.min.js",
                        "~/Content/Client/js/swipebox/jquery.swipebox.js",                    
                        "~/Content/Client/js/jplist-core.min.js",
                        "~/Content/Client/js/jplist.pagination-bundle.min.js",
                        "~/Content/Client/js/jplist.sort-bundle.min.js",
                        "~/Content/Client/js/myscripts.js"
                        ));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/Client/css/bootstrap.css",
                      "~/Content/Client/css/bootflat.css",                     
                      "~/Content/Client/css/animate.css",
                      "~/Content/Client/css/hover.css",
                      "~/Content/Client/css/revslider.css",
                      "~/Content/Client/css/extralayers.css",                      
                      "~/Content/Client/css/flexslider.css",
                      "~/Content/Client/css/slick.css",
                      "~/Content/Client/css/slick-theme.css",                      
                      "~/Content/Client/css/jplist-core.min.css",
                      "~/Content/Client/css/jplist-demo-pages.min.css",
                      "~/Content/Client/css/jplist-pagination-bundle.min.css",
                      "~/Content/Client/css/style.css"

                      ));
            BundleTable.EnableOptimizations = true;
        }
    }
}
