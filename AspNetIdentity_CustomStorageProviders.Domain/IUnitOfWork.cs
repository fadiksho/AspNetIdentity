using AspNetIdentity_CustomStorageProviders.Domain.Entities;
using AspNetIdentity_CustomStorageProviders.Domain.Repositories;
using System;

namespace AspNetIdentity_CustomStorageProviders.Domain
{
  public interface IUnitOfWork : IDisposable
  {
    IRoleRepository RoleRepository { get; }
    IRoleClaimRepository RoleClaimRepository { get; }
    IUserRepository UserRepository { get; }
    IUserClaimRepository UserClaimRepository { get; }
    IUserLoginRepository UserLoginRepository { get; }
    IRepository<UserToken, UserTokenKey> UserTokenRepository { get; }
    IUserRoleRepository UserRoleRepository { get; }

    void Commit();
  }
}
