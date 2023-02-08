using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubeIntersection.Tests
{
    [TestClass()]
    public class CubeTests
    {
        [TestMethod()]
        public void CubeTest()
        {
            Assert.ThrowsException<ArgumentException>( () =>
            {
                var cube1 = new Cube( 1, new Vector( 2 ) );
            }, "The center of a cube must be a 3-dimensional vector." );           
        }

        [TestMethod()]
        public void CollitionCheckTest()
        {
            var cube1 = new Cube( 1, new Vector( 3 ) );
            var cube2 = new Cube( 1, new Vector( new double[] { 3, 3, 3 } ) );
            var cube3 = new Cube( 1, new Vector( new double[] { 0.9, 0, 0 } ) );

            Assert.IsTrue( Cube.CollitionCheck( cube1, cube1 ) );            
            Assert.IsFalse( Cube.CollitionCheck( cube1, cube2 ) );
            Assert.IsTrue( Cube.CollitionCheck( cube1, cube3 ) );
        }

        [TestMethod()]
        public void IntersectedVolumeTest()
        {
            var cube1 = new Cube( 1, new Vector( 3 ) );
            var cube2 = new Cube( 1, new Vector( new double[] { 3, 3, 3 } ) );
            var cube3 = new Cube( 1, new Vector( new double[] { 0.9, 0, 0 } ) );

            Assert.ThrowsException<ArgumentException>( () =>
            {
                Cube.IntersectedVolume( cube1, cube2 );
            }, "Cubes are not intersected." );

            Assert.AreEqual(Cube.IntersectedVolume( cube1, cube1 ), 1);

            Assert.IsTrue( Math.Abs( Cube.IntersectedVolume( cube1, cube3 ) - 0.1 ) < 0.1e-8 );
        }
    }
}