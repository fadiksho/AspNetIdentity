using AspNetIdentity_CustomStorageProviders.Domain.Entities;
using System.Collections.Generic;

namespace AspNetIdentity_CustomStorageProviders.Domain.Repositories
{
  public interface IRoleClaimRepository : IRepository<RoleClaim, int>
  {
    IEnumerable<RoleClaim> FindByRoleId(string roleId);
  }
}
