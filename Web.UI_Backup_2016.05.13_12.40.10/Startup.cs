// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="">
//   
// </copyright>
// <summary>
//   The startup.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Microsoft.Owin;

using Web.UI;

[assembly: OwinStartup(typeof(Startup))]

namespace Web.UI
{
    using Owin;

    /// <summary>
    /// The startup.
    /// </summary>
    public partial class Startup
    {
        /// <summary>
        /// The configuration.
        /// </summary>
        /// <param name="app">
        /// The app.
        /// </param>
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
