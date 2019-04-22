namespace AspNetIdentity_CustomStorageProviders.Domain.Entities
{
  public class ClaimBase
  {
    public int Id { get; set; }
    public string ClaimType { get; set; }
    public string ClaimValue { get; set; }
  }
}
