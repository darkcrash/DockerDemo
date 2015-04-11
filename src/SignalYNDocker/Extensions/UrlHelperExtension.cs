using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet;
using Microsoft.AspNet.Mvc;

namespace SignalYN
{
    public static class UrlHelperExtension
    {
        public static string AppUrl(this IUrlHelper urlHelper)
        {
            //var request = urlHelper.RequestContext.HttpContext.Request;
            var request = System.Web.HttpContext.Current.Request;
            return request.Url.GetLeftPart(UriPartial.Scheme | UriPartial.Authority);
        }
    }
}