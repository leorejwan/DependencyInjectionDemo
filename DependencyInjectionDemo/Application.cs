using LibraryDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo
{
    internal class Application : IApplication
    {
        IBusinnessLogic _bussinessLogic;
        public Application(IBusinnessLogic businnessLogic)
        {
            _bussinessLogic = businnessLogic;
        }

        public void Run()
        {
            _bussinessLogic.ProcessData();
        }
    }
}
