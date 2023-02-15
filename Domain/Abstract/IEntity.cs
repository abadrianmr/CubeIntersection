using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstract
{
    /// <summary>
    /// Describe las propiedades y la funcionalidad que deben declararse en el 
    /// modelado de una entidad.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Identificador de la entidad.
        /// </summary>
        int EntityId { get; set; }
    }
}
