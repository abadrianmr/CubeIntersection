using Autofac.Features.ResolveAnything;
using Autofac;
using System.Windows;
using Repository;
using Repository.Abstract;
using WpfUI.Services.Abstract;
using WpfUI.Services;

namespace WpfUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IContainer _container;
        private INavigationService _navigationService;

        public App()
        {
            ConfigureContainer();
            ResolveDependencies();
        }

        void ResolveDependencies() 
        {
            // Resolve necessary dependencies Ex: NavigationService, AppState, etc...
            _navigationService = _container.Resolve<INavigationService>();
        }
        void ConfigureContainer()
        {
            // Create the builder with which components/services are registered.
            var builder = new ContainerBuilder();

            CubeIntersectionRepository repository = new CubeIntersectionRepository();

            // Register types that expose interfaces...
            builder.RegisterInstance( repository ).As<ICubeRepository>();
            builder.RegisterType<NavigationService>().As<INavigationService>();
            // If new entities are added, new corresponding repositories should be registered here.
            builder.RegisterSource( new AnyConcreteTypeNotAlreadyRegisteredSource() );

            _container = builder.Build();
        }

        protected override void OnStartup( StartupEventArgs e )
        {
            _navigationService.ShowMainWindow();

        }
    }
}
