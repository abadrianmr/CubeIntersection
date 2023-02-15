using Domain.Builders.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Builders
{
    /// <summary>
    /// Helper to build a cube.
    /// </summary>
    public class CubeBuilder : ICubeBuilder
    {
        private Cube _cube;
        public CubeBuilder()
        {
            _cube = new Cube();
        }
        public ICubeBuilder SetCenter( double[] center )
        {
            _cube.Center = center;
            return this;
        }
        public ICubeBuilder SetSize( double size )
        {
            _cube.Size = size;
            return this;
        }

        public void Reset()
        {
            _cube = new Cube();
        }

        public Cube GetCube()
        {
            return _cube;
        }
    }
}
