namespace ConsoleApp1.BaseServiceApp
{
    public interface IBaseService
    {
        string Name { get; set; }

        IBaseServiceFactory Factory { get; set; }
    }
}