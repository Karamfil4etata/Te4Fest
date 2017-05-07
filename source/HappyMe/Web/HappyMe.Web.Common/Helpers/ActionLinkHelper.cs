﻿using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace HappyMe.Web.Common.Helpers
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Routing;
    using System;

    public static class ActionLinkHelper
    {
        public static IHtmlContent ActiveActionLinkHelper(this IHtmlHelper helper, string linkText, string actionName, string controllerName, RouteValueDictionary routeValues, RouteValueDictionary htmlAttributes)
        {
            var currentControllerName = /*helper.ViewContext.HttpContext.*/ string.Empty; // TODO: Get controller name here
            
            if (currentControllerName.Equals(controllerName + "Controller", StringComparison.OrdinalIgnoreCase))
            {
                htmlAttributes["class"] += " active";
            }

            return helper.ActionLink(linkText, actionName, controllerName, routeValues, htmlAttributes);
        }

        public static IHtmlContent DashboardLink(this IHtmlHelper helper)
        {
            return helper.ActionLink("Dashboard", "Index", new { controller = "Начална страница", area = "Administration" }, new { @class = "btn btn-primary bottom-buffer" });
        }
    }
}