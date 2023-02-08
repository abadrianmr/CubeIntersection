

namespace CubeIntersection
{
    /// <summary>
    /// Models a cube.
    /// </summary>
    public class Cube
    {
        #region Properties

        /// <summary>
        /// Cube Size.
        /// </summary>
        public double Size { get; set; }

        public Vector Center { get; set; }        

        #endregion

        #region Constructors

        public Cube( double size, Vector center )
        {
            if( center.Length != 3 )
                throw new ArgumentException( "The center of a cube must be a 3-dimensional vector." );


            Size = size;
            Center = center;
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
        /// Calculate the intersected volume of two cubes.
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