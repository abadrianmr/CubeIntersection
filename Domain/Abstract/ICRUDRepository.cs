using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Clase base para repositorios de base de datos.
    /// </summary>
    public interface ICRUDRepository : IRepository
    {                        
        #region CRUD

        public TEntity GetByID<TEntity>( object id ) where TEntity : IEntity;

        public void Add<TEntity>( TEntity entity ) where TEntity : IEntity;

        public void Delete<TEntity>( TEntity entityToDelete ) where TEntity : IEntity;

        public void Update<TEntity>( TEntity entityToUpdate ) where TEntity : IEntity;

        #endregion 
    }
}
