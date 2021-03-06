﻿using System.Web;
using System.Web.Optimization;

namespace SignalYN
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/chart.js",
                "~/Scripts/angular.js",
                "~/Scripts/jquery.signalR-{version}.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jquery")
            {
                CdnPath = "//ajax.aspnetcdn.com/ajax/jquery/jquery-1.10.2.min.js",
                CdnFallbackExpression = "window.jQuery"
            }.Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/chartjs").Include("~/Scripts/chart.js"));
            bundles.Add(new ScriptBundle("~/bundles/angularjs")
            {
                CdnPath = "//ajax.googleapis.com/ajax/libs/angularjs/1.2.24/angular.min.js",
                CdnFallbackExpression = "window.angular"
            }.Include("~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery.signalR")
            {
                CdnPath = "//ajax.aspnetcdn.com/ajax/signalr/jquery.signalr-2.1.0.min.js",
                CdnFallbackExpression = "window.jQuery.connection"
            }.Include("~/Scripts/jquery.signalR-{version}.js"));

            bundles.UseCdn = true;

            bundles.Add(new StyleBundle("~/content/css").Include(
                "~/Content/normalize.css",
                "~/Content/site.css"));
        }
    }
}
