using AspNetIdentity_CustomStorageProviders.Domain.Entities;
using System.Collections.Generic;

namespace AspNetIdentity_CustomStorageProviders.Domain.Repositories
{
  public interface IUserLoginRepository : IRepository<UserLogin, UserLoginKey>
  {
    IEnumerable<UserLogin> FindByUserId(string userId);
  }
}
