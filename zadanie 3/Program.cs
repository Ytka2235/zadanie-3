using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задание 3");
        AllInfoProcess();
    }
    static void AllInfoProcess()
    {
        var myProcess = from proc in Process.GetProcesses(".")
                        orderby proc.BasePriority
                        select proc;
        Console.WriteLine("\n*** Текущие процессы ***\n");
        foreach (var p in myProcess)
            Console.WriteLine("-> PID: {0}\tName: {1}", p.Id, p.ProcessName);
        
    }
}