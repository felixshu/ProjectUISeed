// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HMTLHelperExtensions.cs" company="">
//   
// </copyright>
// <summary>
//   The hmtl helper extensions.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Web.Mvc;
using static System.String;

namespace Web.UI.Helpers
{
    

    /// <summary>
    /// The hmtl helper extensions.
    /// </summary>
    public static class HmtlHelperExtensions
    {
        /// <summary>
        /// The is selected.
        /// </summary>
        /// <param name="html">
        /// The html.
        /// </param>
        /// <param name="controller">
        /// The controller.
        /// </param>
        /// <param name="action">
        /// The action.
        /// </param>
        /// <param name="cssClass">
        /// The css class.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string IsSelected(this HtmlHelper html, string controller = null, string action = null, string cssClass = null)
        {

            if (IsNullOrEmpty(cssClass))
                cssClass = "active";

            string currentAction = (string)html.ViewContext.RouteData.Values["action"];
            string currentController = (string)html.ViewContext.RouteData.Values["controller"];

            if (IsNullOrEmpty(controller))
                controller = currentController;

            if (IsNullOrEmpty(action))
                action = currentAction;

            return controller == currentController && action == currentAction ?
                cssClass : string.Empty;
        }

        /// <summary>
        /// The page class.
        /// </summary>
        /// <param name="html">
        /// The html.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string PageClass(this HtmlHelper html)
        {
            string currentAction = (string)html.ViewContext.RouteData.Values["action"];
            return currentAction;
        }
    }
}
