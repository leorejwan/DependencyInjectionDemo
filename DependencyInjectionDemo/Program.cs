using Autofac;
using DependencyInjectionDemo;
using LibraryDemo;

var container = ContainerConfig.Configure();

using (var scope = container.BeginLifetimeScope())
{
    var app = scope.Resolve<IApplication>();
    app.Run();
}