using System.Web;
using System.Web.Optimization;

namespace WebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //BundleTable.EnableOptimizations = true;
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-2.1.3.min.js",
                        "~/Scripts/jquery.validate.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.min.js"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/global/plugins/bootstrap/js/bootstrap.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrapcss").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/bootstrap-theme.min.css"));


            bundles.Add(new StyleBundle("~/Content/themecss").Include(
                      "~/Content/global/plugins/font-awesome/css/font-awesome.min.css",
                      "~/Content/global/plugins/simple-line-icons/simple-line-icons.min.css",
                      "~/Content/global/plugins/bootstrap/css/bootstrap.min.css",
                      "~/Content/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css",
                      "~/Content/global/css/components.min.css",
                      "~/Content/global/css/plugins.min.css",
                      "~/Content/layouts/layout/css/layout.min.css",
                      "~/Content/layouts/layout/css/themes/darkblue.css",
                      "~/Content/layouts/layout/css/custom.min.css"));



            bundles.Add(new ScriptBundle("~/bundles/themescript").Include(
                                    "~/Content/global/plugins/js.cookie.min.js",
                                    "~/Content/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js",
                                    "~/Content/global/plugins/jquery.blockui.min.js",
                                    "~/Content/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js",
                                    "~/Content/global/scripts/datatable.js",
                                    "~/Content/global/plugins/datatables/datatables.min.js",
                                    "~/Content/global/plugins/datatables/plugins/bootstrap/datatables.bootstrap.js",
                                    "~/Content/global/plugins/bootstrap-datepicker/js/bootstrap-datepicker.min.js",
                                    "~/Content/global/plugins/bootstrap-datetimepicker/js/bootstrap-datetimepicker.min.js",
                                    "~/Content/global/plugins/bootstrap-maxlength/bootstrap-maxlength.min.js",
                                    "~/Content/global/scripts/app.min.js",
                                    "~/Content/layouts/layout/scripts/layout.min.js",
                                    "~/Content/layouts/layout/scripts/demo.min.js",
                                    "~/Content/layouts/global/scripts/quick-sidebar.min.js",
                                    "~/Content/layouts/global/scripts/quick-nav.min.js"));

        }
    }
}
