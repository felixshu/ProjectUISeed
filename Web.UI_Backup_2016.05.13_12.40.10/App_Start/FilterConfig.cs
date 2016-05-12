// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FilterConfig.cs" company="">
//   
// </copyright>
// <summary>
//   The filter config.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Web.UI
{
    using System.Web.Mvc;

    /// <summary>
    /// The filter config.
    /// </summary>
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
