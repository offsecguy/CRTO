using System.ServiceProcess;

static class Program
{
    static void Main()
    {
        ServiceBase[] ServicesToRun;
        ServicesToRun = new ServiceBase[]
        {
            new AdminService()
        };
        ServiceBase.Run(ServicesToRun);
    }
}
