using Repository.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUI
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private double _cubeSize;

        public double CubeSize
        {
            get { return _cubeSize; }
            set 
            { 
                _cubeSize = value;
                PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( nameof( CubeSize ) ) );
            }
        }


        public MainViewModel(ICubeRepository cubeRepository)
        {
            var cube = cubeRepository.CreateCube(3, new double[] {1,2,3});

            CubeSize = cube.Size;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
