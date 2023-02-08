using System.Numerics;

namespace CubeIntersection
{
    /// <summary>
    /// Models a vector of real numbers.
    /// </summary>
    public class Vector
    {
        #region Private fields

        private double[] _vector;

        #endregion

        #region Properties

        /// <summary>
        /// Vector length.
        /// </summary>
        public int Length { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Construct a null vector.
        /// </summary>
        /// <param name="ndim">
        /// Vector dimension.
        /// </param>
        public Vector( int ndim )
        {
            Length = ndim;
            _vector = new double[ ndim ];
            for( int i = 0; i < ndim; i++ )
                _vector[ i ] = 0.0;
        }

        /// <summary>
        /// Construct a vector of real numbers.
        /// </summary>
        /// <param name="v">
        /// Vector values.
        /// </param>
        public Vector( double[] v )
        {
            Length = v.Length;
            _vector = (double[]) v.Clone();
        }

        #endregion

        #region Operands Overload

        /// <summary>
        /// Bracket operator overload, provides access to vector values.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public double this[ int i ]
        {
            get
            {
                return _vector[ i ];
            }
            set { _vector[ i ] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector operator -( Vector v1, Vector v2 )
        {
            var result = new Vector( v1.Length );
            for( int i = 0; i < v1.Length; i++ )
                result[ i ] = v1[ i ] - v2[ i ];
            return result;
        }

        #endregion

        /// <summary>
        /// Calculate the norm of the vector.
        /// </summary>
        /// <param name="p">
        /// Order or the norm.
        /// </param>
        /// <returns>
        /// Norm.
        /// </returns>
        public double GetNorm( int p = 2 )
        {
            double result = 0.0;
            for( int i = 0; i < Length; i++ )
                result += Math.Pow( Math.Abs( _vector[ i ] ), p );
            return Math.Pow( result, 1.0 / p );
        }

        /// <summary>
        /// Add new values ​​to the vector.
        /// </summary>
        /// <param name="nvals">
        /// New values.
        /// </param>
        public void Append( Vector nvals )
        {
            double[] temp = _vector;
            _vector = new double[ Length + nvals.Length ];
            int j = 0;
            for( int i = 0; i < Length; i++ )
            {
                _vector[ j ] = temp[ i ];
                j++;
            }
            for( int i = 0; i < nvals.Length; i++ )
            {
                _vector[ j ] = nvals[ i ];
                j++;
            }
            Length += nvals.Length;
        }


        /// <summary>
        /// Calculate the dot product of two vectors
        /// <param name="v1">
        /// First vector.
        /// </param>
        /// <param name="v2">
        /// Second vector.
        /// </param>
        /// <returns>
        /// Operation result.
        /// </returns>
        public static double EuclideanDistance( Vector v1, Vector v2 )
        {
            if( v1.Length != v2.Length )
                throw new ArgumentException( "The dimensions of the vectors must be equal." );

            var result = (v2 - v1).GetNorm();
            
            return result;
        }        
    }
}