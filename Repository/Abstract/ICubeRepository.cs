using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstract
{
    public interface ICubeRepository : IRepository
    {
        /// <summary>
        /// Create a new <see cref="Cube" /> in the persistence system.
        /// </summary>
        /// <param name="size">
        /// Size of the cube.
        /// </param>
        /// <param name="center">
        /// Center of the cube.
        /// </param>
        /// <returns>
        /// An object <see cref="Cube"/>.
        /// </returns>
        Cube CreateCube( double size, double[] center );
        /// <summary>
        /// Delete a <see cref="Cube" /> in the persistence system.
        /// </summary>
        /// <param name="cube">
        /// An object <see cref="Cube"/>.
        /// </param>
        /// <param name="progress">
        /// An object <see cref="Progress{T}"/> to report the progress of the operation.
        /// </param>
        void DeleteCube( Cube cube, IProgress<Tuple<int, int>> progress = null );
        /// <summary>
        /// Update a <see cref="Cube" /> in the persistence system..
        /// </summary>
        /// <param name="cube">
        /// An object <see cref="Cube"/>.
        /// </param>
        void UpdateCube( Cube cube );
        /// <summary>
        /// Get all the <see cref="Cube" /> from the persistence system.
        /// </summary>
        /// <returns>
        /// A collection <see cref="Cube"/>.
        /// </returns>
        List<Cube> GetCubes();
    }
}
