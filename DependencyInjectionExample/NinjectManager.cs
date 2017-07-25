using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    class NinjectManager
    {
        ILogger _logger;

        public NinjectManager(ILogger logger)
        {
            this._logger = logger;
        }


        public  void NinjaEkle(Ninja ninja)
        {
            _logger.LogAt();
            //Ninja ekleme işlemleri
        }
    }
}
