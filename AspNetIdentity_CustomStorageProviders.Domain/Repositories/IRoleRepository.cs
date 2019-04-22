using AspNetIdentity_CustomStorageProviders.Domain.Entities;

namespace AspNetIdentity_CustomStorageProviders.Domain.Repositories
{
  public interface IRoleRepository : IRepository<Role, string>
  {
    Role FindByName(string roleName);
  }
}
