using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstract;

namespace Domain.Entities
{
    /// <summary>
    /// Clase base para las entidades.
    /// </summary>
    public abstract class Entity : IEntity, IEquatable<Entity>
    {
        #region Properties

        /// <summary>
        /// Identificador en la base de datos.
        /// </summary>        
        public int EntityId { get; set; } 
        
        #endregion

        /// <summary>
        /// Indica cuando esta entidad tiene el mismo identificador que la entidad especificada.
        /// </summary>
        /// <param name="other">
        /// Un objeto <see cref="Entity"/> conteniendo la entidad a comparar.
        /// </param>
        /// <returns>
        /// <see langword="true"/>, si la entidad a comparar tiene el mismo identificador que la 
        /// entidad especificada; de lo contrario, <see langword="false"/>.
        /// </returns>
        public bool Equals( Entity other )
        {
            if( other == null )
                return false;
            return this.EntityId == other.EntityId;
        }

        public override bool Equals( object obj )
        {
            return Equals( obj as Entity );
        }

        public override int GetHashCode()
        {
            return HashCode.Combine( this.EntityId );
        }
    }
}
