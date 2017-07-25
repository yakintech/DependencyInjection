using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja ninja = new Ninja();
            ninja.Name = "Çağatay";
            ninja.SurName = "Yıldız";

            ILogger logger = new XMLLogger();
            NinjectManager manager = new NinjectManager(logger);

            manager.NinjaEkle(ninja);
        }
    }
}
