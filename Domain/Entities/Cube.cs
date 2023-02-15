using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cube : Entity
    {
        #region Properties

        private double _size;
        /// <summary>
        /// Cube Size.
        /// </summary>
        public double Size
        {
            get
            {
                return _size;
            }
            set
            {
                if( value < 0 )
                    throw new ArgumentException( "The size must be a value grater than zero." );
                _size = value;
            }
        }
        private double[] _center;
        /// <summary>
        /// 3-dimensional array <see langword="double[]"/> that represent the center of the cube.
        /// </summary>
        public double[] Center
        {
            get
            {
                return _center;
            }
            set
            {
                if( value.Length != 3 )
                    throw new ArgumentException( "The center of a cube must be a 3-dimensional array." );
                _center = value;
            }
        }

        #endregion

        #region Constructors

        internal Cube()
        {

        }

        internal Cube( double size, double[] center )
        {
            Center = (double[])center.Clone();
            Size = size;
        }        

        #endregion
    }
}
