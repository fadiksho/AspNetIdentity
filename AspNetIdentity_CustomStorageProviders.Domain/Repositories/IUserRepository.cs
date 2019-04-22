using AspNetIdentity_CustomStorageProviders.Domain.Entities;

namespace AspNetIdentity_CustomStorageProviders.Domain.Repositories
{
  public interface IUserRepository : IRepository<User, string>
  {
    User FindByNormalizedUserName(string normalizedUserName);
    User FindByNormalizedEmail(string normalizedEmail);
  }
}
