using AspNetIdentity_CustomStorageProviders.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetIdentity_CustomStorageProviders.Identity
{
  public static class IdentityBuilderExtensions
  {
    public static IdentityBuilder AddCustomStores(this IdentityBuilder builder)
    {
      builder.Services.AddTransient<IUserStore<ApplicationUser>, CustomUserStore>();
      builder.Services.AddTransient<IRoleStore<IdentityRole>, CustomRoleStore>();
      return builder;
    }
  }
}
