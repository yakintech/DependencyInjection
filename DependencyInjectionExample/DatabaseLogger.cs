using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    class DatabaseLogger : ILogger
    {
        public void LogAt()
        {
            //db log at
        }
    }
}
