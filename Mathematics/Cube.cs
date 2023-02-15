

namespace Mathematics
{
    /// <summary>
    /// Models a cube.
    /// </summary>
    public class Cube
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
        private Vector _center;
        /// <summary>
        /// s-dimensional vector <see cref="Vector"/> that represent the center of the cube.
        /// </summary>
        public Vector Center 
        {
            get
            {
                return _center;
            }
            set
            {
                if(value.Length != 3)
                    throw new ArgumentException( "The center of a cube must be a 3-dimensional vector." );
                _center = value;
            } 
        }        

        #endregion

        #region Constructors

        public Cube( double size, Vector center )
        {
            Center = center;
            Size = size;            
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Check if to cubes collide. According to https://stackoverflow.com/questions/5009526/overlapping-cubes.
        /// </summary>
        /// <param name="cube1"></param>
        /// <param name="cube2"></param>
        /// <returns>Return true if collide and false otherwise</returns>
        public static bool CollitionCheck( Cube cube1, Cube cube2 )
        {
            var maxAxes = cube1.GetMaxAxes();
            maxAxes.Append(cube2.GetMaxAxes());
            var minAxes = cube2.GetMinAxes();
            minAxes.Append(cube1.GetMinAxes());

            for( int i = 0; i < maxAxes.Length; i++ )
            {
                if( maxAxes[i] <= minAxes[i] )
                {
                    return false;
                }                    
            }

            return true;
        }

        /// <summary>
        /// Calculate the intersected volume of two cubes. According to https://stackoverflow.com/questions/5556170/finding-shared-volume-of-two-overlapping-cuboids
        /// </summary>
        /// <param name="cube1"></param>
        /// <param name="cube2"></param>
        /// <returns>If the cubes are intersected returns the intersected volume</returns>
        /// <exception cref="ArgumentException">In case the cubes aren't intersected</exception>
        public static double IntersectedVolume(Cube cube1, Cube cube2 )
        {
            if( CollitionCheck( cube1, cube2 ) )
            {
                var cube1maxAxes = cube1.GetMaxAxes();
                var cube2maxAxes = cube2.GetMaxAxes();
                var cube1minAxes = cube1.GetMinAxes();
                var cube2minAxes = cube2.GetMinAxes();

                var result = 1.0;

                for( int i = 0; i < cube1.Size; i++ )
                {
                    result *= Math.Max( Math.Min( cube1maxAxes[ i ], cube2maxAxes[ i ] ) - Math.Max( cube1minAxes[ i ], cube2minAxes[ i ] ), 0 );
                }

                return result;
            }
            else
            {
                throw new ArgumentException( "Cubes are not intersected." );
            }
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Return the maximum values of every axes that belong to the cube.
        /// </summary>
        /// <returns>Vector with the maximum axes</returns>
        private Vector GetMaxAxes()
        {
            var result = new Vector( Center.Length );
            for( int i = 0; i < Center.Length; i++ )
            {
                result[i] = Center[ i ] + Size/2.0;
            }
            return result;
        }

        /// <summary>
        /// Return the minimum values of every axes that belong to the cube.
        /// </summary>
        /// <returns>Vector with the minimum axes</returns>
        private Vector GetMinAxes()
        {
            var result = new Vector( Center.Length );
            for( int i = 0; i < Center.Length; i++ )
            {
                result[ i ] = Center[ i ] - Size/2.0;
            }
            return result;
        }

        #endregion
    }
}