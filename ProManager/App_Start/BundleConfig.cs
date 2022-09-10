using System.Web;
using System.Web.Optimization;

namespace ProManager
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Content/vendor/jquery/jquery*"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-easing").Include(
                        "~/Content/vendor/jquery-easing/jquery.easing*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Content/vendor/bootstrap/js/bootstrap.bundle.js"));

            bundles.Add(new ScriptBundle("~/bundles/sb-admin").Include(
                        "~/Content/vendor/sb-admin/sb-admin-*"));

            bundles.Add(new ScriptBundle("~/bundles/fontawesome").Include(
                       "~/Content/vendor/fontawesome-free/js/all*",
                       "~/Content/vendor/fontawesome-free/js/fontawesome*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información sobre los formularios.  De esta manera estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/vendor/fontawesome-free/css/all.css",
                      "~/Content/vendor/fontawesome-free/css/fontawesome.css",
                      "~/Content/vendor/sb-admin/css/sb-admin-2.css",
                      "~/Content/vendor/sb-admin/css/sb-admin-2.min.css",
                      "~/Content/vendor/bootstrap/css/bootstrap.css"));

        }
    }
}
