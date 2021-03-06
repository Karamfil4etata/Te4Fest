﻿namespace HappyMe.Web
{
    using System.Web.Optimization;

    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterScriptBundles(bundles);
            RegisterStyleBundles(bundles);
        }

        private static void RegisterStyleBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/landing-page").Include(
                "~/Content/vendor/bootstrap/bootstrap.css",
                "~/Content/custom/global.css",
                "~/Content/custom/reset-css.css",
                "~/Content/custom/landing-page.css",
                "~/Content/custom/override.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/vendor/bootstrap/bootstrap.css",
                "~/Content/custom/global.css",
                "~/Content/custom/reset-css.css",
                "~/Content/custom/site.css",
                "~/Content/custom/override.css"));

            bundles.Add(new StyleBundle("~/Content/administration-css").Include(
                "~/Content/vendor/MvcGrid/mvc-grid.css",
                "~/Content/vendor/bootstrap/administration/style.css",
                "~/Content/vendor/bootstrap/administration/style-responsive.css",
                "~/Content/vendor/chosen/chosen.css",
                "~/Content/fonts/lato/latostyle.css",
                "~/Content/custom/administration-styles.css",
                "~/Content/custom/global.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                "~/Content/vendor/bootstrap/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/jquery-gritter").Include(
                "~/Scripts/vendor/jquery/gritter/css/jquery.gritter.css"));

            bundles.Add(new StyleBundle("~/Content/font-awesome").Include(
                "~/Content/fonts/font-awesome/css/font-awesome.css"));

            bundles.Add(new StyleBundle("~/Content/lato-font").Include(
                "~/Content/fonts/lato/latofonts.css"));

            bundles.Add(new StyleBundle("~/Content/guillotine").Include(
                "~/Content/vendor/guillotine/jquery.guillotine.css"));

            bundles.Add(new StyleBundle("~/Content/slick").Include(
                "~/Scripts/vendor/SlickSlider/slick/slick.css",
                "~/Scripts/vendor/SlickSlider/slick/slick-theme.css"));

            bundles.Add(new StyleBundle("~/Content/result-screens").Include(
                "~/Content/custom/result-screens.css"));
        }

        private static void RegisterScriptBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/vendor/jquery/jquery-{version}.js",
                "~/Scripts/vendor/q/q.js",
                "~/Scripts/custom/common/http-requester.js"));

            bundles.Add(new ScriptBundle("~/bundles/ckeditor").Include(
                "~/Scripts/vendor/ckeditor/ckeditor.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/vendor/jquery/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/vendor/modernizr/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/vendor/bootstrap/bootstrap.min.js",
                "~/Scripts/vendor/respond/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/administration-scripts").Include(
                "~/Scripts/custom/administration/common/*.js",
                "~/Scripts/custom/administration/data/*.js",
                "~/Scripts/custom/administration/statistics/*.js",
                "~/Scripts/custom/common/color-utils.js",
                "~/Scripts/vendor/MvcGrid/mvc-grid.js",
                "~/Scripts/vendor/bootstrap/administration-theme-common/common-scripts.js",
                "~/Scripts/vendor/chart/Chart.js",
                "~/Scripts/vendor/chosen/chosen.jquery.js"));

            bundles.Add(new StyleBundle("~/bundles/jquery-gritter").Include(
               "~/Scripts/vendor/jquery/gritter/js/jquery-gritter.js",
               "~/Scripts/vendor/jquery/gritter/gritter-conf.js"));

            bundles.Add(new ScriptBundle("~/bundles/nice-scroll").Include(
                "~/Scripts/vendor/jquery/jquery.nicescroll.js"));

            bundles.Add(new ScriptBundle("~/bundles/guillotine").Include(
                "~/Scripts/vendor/guillotine/jquery.guillotine.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/slick").Include(
                "~/Scripts/vendor/SlickSlider/slick/slick.min.js"));
        }
    }
}
