using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstract
{
    /// <summary>
    /// Define la funcionalidad básica de un repositorio.
    /// </summary>
    public interface IRepository : IDisposable
    {
        /// <summary>
        /// Indicador de transacción en curso.
        /// <see langword="true"/>, si existe una transacción en curso;
        /// de lo contrario, <see langword="false"/>.
        /// </summary>
        bool IsInTransaction { get; }
        /// <summary>
        /// Inicia una transacción.
        /// </summary>        
        void BeginTransaction();
        /// <summary>
        /// Realiza una salva manteniendo la transacción abierta.
        /// </summary>
        void PartialCommit();
        /// <summary>
        /// Finaliza y da persistencia a una transacción.
        /// </summary>
        void CommitTransaction();
        /// <summary>
        /// Deshace una transacción, si esta no se ha finalizado.
        /// </summary>
        void RollbackTransaction();
    }
}
