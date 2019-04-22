using AspNetIdentity_CustomStorageProviders.Domain.Entities;
using System.Collections.Generic;

namespace AspNetIdentity_CustomStorageProviders.Domain.Repositories
{
  public interface IUserClaimRepository : IRepository<UserClaim, int>
  {
    IEnumerable<UserClaim> GetByUserId(string userId);
    IEnumerable<User> GetUsersForClaim(string claimType, string claimValue);
  }
}
