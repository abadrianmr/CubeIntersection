using Domain.Abstract;
using Domain.Entities;

namespace Repository
{
    /// <summary>
    /// Implementation of this class must be according to the selected persistence method for this project.
    /// </summary>
    public partial class CubeIntersectionRepository : ICRUDRepository
    {
        #region IRepository
        public bool IsInTransaction => throw new NotImplementedException();

        public void Add<TEntity>( TEntity entity ) where TEntity : IEntity => throw new NotImplementedException();
        public void BeginTransaction() => throw new NotImplementedException();
        public void CommitTransaction() => throw new NotImplementedException();
        public void Delete<TEntity>( TEntity entityToDelete ) where TEntity : IEntity => throw new NotImplementedException();
        public void Dispose() => throw new NotImplementedException();
        #endregion

        #region ICRUDRepository
        public TEntity GetByID<TEntity>( object id ) where TEntity : IEntity => throw new NotImplementedException();
        public void PartialCommit() => throw new NotImplementedException();
        public void RollbackTransaction() => throw new NotImplementedException();
        public void Update<TEntity>( TEntity entityToUpdate ) where TEntity : IEntity => throw new NotImplementedException();
        #endregion
    }
}
