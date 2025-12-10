using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BaseServiceApp
{
    public abstract class BaseService :  IBaseService
    {
        public string Name { get; set; }

        public IBaseServiceFactory Factory { get; set; }
    }
}
