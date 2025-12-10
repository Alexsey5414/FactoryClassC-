using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BaseServiceApp
{
    public class ServiceCreator<T>
    {
        
       public T Create()
        {
            return Activator.CreateInstance<T>();
        }
    }
}
