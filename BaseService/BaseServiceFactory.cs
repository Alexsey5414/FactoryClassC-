using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BaseServiceApp
{
    public abstract class BaseServiceFactory<T> :IBaseServiceFactory
    {
        protected ServiceCreator<T> serviceCreator;
        public Type GetTypeFactory() => this.GetType();
        public string Name { get; set; }
        public IBaseService CreateService()
        {
            if (serviceCreator.Create() is IBaseService instance)
            {
                instance.Factory = this;
                return instance;
            }
            else throw new NotImplementedException();
        }
    }
}
