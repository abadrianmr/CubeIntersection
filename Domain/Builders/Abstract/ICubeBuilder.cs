using Domain.Entities;

namespace Domain.Builders.Abstract
{
    /// <summary>
    /// Every method returns an <see cref="ICubeBuilder"/> in order to concatenate operations.
    /// </summary>
    public interface ICubeBuilder
    {
        ICubeBuilder SetSize(double size);

        ICubeBuilder SetCenter( double[] center);

        public Cube GetCube();
    }
}
