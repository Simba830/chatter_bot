using System.Collections.Generic;

namespace ChatterBot.Data
{
    public interface IDataStore
    {
        void EnsureSchema();
        List<TEntity> GetEntities<TEntity>();
        void SaveEntities<TEntity>(IEnumerable<TEntity> entities);
    }
}