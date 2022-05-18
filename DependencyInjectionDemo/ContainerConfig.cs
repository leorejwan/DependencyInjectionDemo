using Autofac;
using LibraryDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo
{
    internal static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<BusinnessLogic>().As<IBusinnessLogic>();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(LibraryDemo)))
                .Where(x => x.Namespace!.Contains("Utilities"))
                .As(x => x.GetInterfaces().First(y => y.Name == "I" + x.Name));

            return builder.Build();
        }
    }
}
