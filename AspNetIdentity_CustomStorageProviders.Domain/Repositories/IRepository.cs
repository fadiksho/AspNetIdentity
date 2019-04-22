using System.Collections.Generic;

namespace AspNetIdentity_CustomStorageProviders.Domain.Repositories
{
  public interface IRepository<TEntity, TKey> where TEntity : class
  {
    IEnumerable<TEntity> All();
    TEntity Find(TKey key);
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Remove(TKey key);
  }
}
