namespace AspNetIdentity_CustomStorageProviders.Domain.Entities
{
  public class UserClaim : ClaimBase
  {
    public string UserId { get; set; }
  }
}
