using AspNetIdentity_CustomStorageProviders.Domain.Entities;
using System.Collections.Generic;

namespace AspNetIdentity_CustomStorageProviders.Domain.Repositories
{
  public interface IUserRoleRepository
  {
    void Add(string UserId, string roleName);
    void Remove(string userId, string roleName);
    IEnumerable<string> GetRoleNamesByUserId(string userId);
    IEnumerable<User> GetUsersByRoleName(string roleName);
  }
}
