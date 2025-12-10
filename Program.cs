
using ConsoleApp1.BaseServiceApp;
using ConsoleApp1.FactoryStorage;
using ConsoleApp1.FileServiceApp;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            //DI
            var serviseFileCreator = new ServiceCreator<FileService>();
    
             var fileFactory = new FileFactory(serviseFileCreator);

            var serviceFtpCreator = new ServiceCreator<FTPService>();
            var ftpFactory = new FTPFactory(serviceFtpCreator);
            var listDifferentFactories = new List<IBaseServiceFactory>() { fileFactory, ftpFactory };

            var fls = new FactoryListStorage(listDifferentFactories);




            var listTypeFactories = new List<IBaseServiceFactory>() { ftpFactory, fileFactory, fileFactory, ftpFactory };

            var ftls = new FactoryTypeListStorage<IBaseServiceFactory>(listTypeFactories);
             

            //////////////////////////////////////////////////
            //У потребителя
            //FileService
            var factoryFile = fls.GetFactory<FileFactory>();
            var instanceFileService = factoryFile.CreateService();

            var serviceFileName = ((IFileService)instanceFileService).GetNameService();
            Console.WriteLine($"serviseFileName {serviceFileName}");

            //FtpService
            var factoryFtp = fls.GetFactory<FTPFactory>();
            var instanceFtpService = factoryFtp.CreateService();
            var serviceFtpName = ((IFTPService)instanceFtpService).GetNameService();
            Console.WriteLine($"serviseFtpName {serviceFtpName}");
            //Общий вариант
            var commonFileFactory = new CommonFactory<FileService>(serviseFileCreator);
            var commonFileService = commonFileFactory.CreateService();

            var factoryName = commonFileService.Factory.Name;

            Console.WriteLine($"factoryName {factoryName}");
            var commonFileServiceName = ((IFileService)commonFileService).GetNameService();
            Console.WriteLine($"commonFileServiceName {commonFileServiceName}");
            //тип как список
            var factoryTypeFile = ftls.GetFactory<FTPFactory>();
            var instanceTypeFileService = factoryTypeFile.CreateService() as IFTPService;


            var serviceTypeFileName = instanceTypeFileService.GetNameService();
            Console.WriteLine($"serviceTypeFileName {serviceTypeFileName}");

            Console.ReadLine();
        }
    }
}
