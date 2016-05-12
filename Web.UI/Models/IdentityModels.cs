// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IdentityModels.cs" company="">
//   
// </copyright>
// <summary>
//   The application user.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Web.UI.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    /// <summary>
    /// The application user.
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
    }

    /// <summary>
    /// The application db context.
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}