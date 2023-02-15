using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematics;

namespace CubeIntersection.Tests
{
    [TestClass()]
    public class VectorTests
    {
        /// <summary>
        /// Test <see cref="Vector"/> constructors
        /// </summary>
        [TestMethod()]
        public void VectorTest()
        {
            Assert.ThrowsException<OverflowException>( () =>
            {
                var vector1 = new Vector( -2 );
            }, "Arithmetic operation resulted in an overflow." );    
            
            var vector2 = new Vector( 3 );
            Assert.IsTrue( vector2.Length == 3 );
        }

        /// <summary>
        /// Test <see cref="Vector.GetNorm(int)"/> method with a with a Pythagorean trio (3,4,5)
        /// </summary>
        [TestMethod()]
        public void GetNormTest()
        {
            var vector1 = new Vector( new double[] { 3, 4 } );

            Assert.IsTrue( vector1.GetNorm() == 5 );
        }

        /// <summary>
        /// Test <see cref="Vector.Append(Vector)"/> method
        /// </summary>
        [TestMethod()]
        public void AppendTest()
        {
            var vector1 = new Vector( new double[] { 1 } );
            var vector2 = new Vector( new double[] { 2 } );
            vector1.Append( vector2 );

            Assert.IsTrue( vector1.Length == 2 && vector1[ vector1.Length - 1 ] == vector2[ 0 ] );            
        }

        /// <summary>
        /// Test <see cref="Vector.EuclideanDistance(Vector, Vector)"/> method with two canonical vectors.
        /// </summary>
        [TestMethod()]
        public void EuclideanDistanceTest()
        {
            var vector1 = new Vector( new double[] { 1, 0 } );
            var vector2 = new Vector( new double[] { 0, 1 } );

            Assert.IsTrue( Math.Abs( Vector.EuclideanDistance( vector1, vector2 ) - Math.Sqrt(2)) < 0.1e-8 );
        }
    }
}