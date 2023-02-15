using Domain.Builders;
using Domain.Entities;
using Repository.Abstract;

namespace Repository
{
    /// <summary>
    /// Implementation of ICubeRepository, this partial implementation should use the general <see cref="Abstract.ICRUDRepository"/> implementations already defined.
    /// </summary>
    public partial class CubeIntersectionRepository : ICubeRepository
    {
        public Cube CreateCube( double size, double[] center )
        {
            CubeBuilder builder = new CubeBuilder();
            var cube = builder.SetCenter( center ).SetSize( size ).GetCube();     

            ///Add( cube );
            return cube;
        }
        public void DeleteCube( Cube cube, IProgress<Tuple<int, int>> progress = null ) => throw new NotImplementedException();
        public List<Cube> GetCubes() => throw new NotImplementedException();
        public void UpdateCube( Cube cube ) => throw new NotImplementedException();
    }
}
