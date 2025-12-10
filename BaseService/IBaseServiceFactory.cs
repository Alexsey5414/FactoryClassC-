using System;

namespace ConsoleApp1.BaseServiceApp
{
    public interface IBaseServiceFactory
    {
         IBaseService CreateService();
         Type GetTypeFactory();
         string Name { get; set; }
    }
}