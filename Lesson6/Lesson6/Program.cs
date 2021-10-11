using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson6
{
    class Program
    {
        static void ShowProcessList()
        {
            Process[] ProcList = Process.GetProcesses();

            Console.WriteLine(String.Format("{0,-26}{1,7}{2,12}{3,15}",
                            "Process Name", "ID", "Session ID", "Memory Size"));
            Console.WriteLine(String.Format("{0,-26}{1,7}{2,12}{3,15}",
                            "==========================", "======", "===========", "=============="));
            foreach (Process p in ProcList)
            {
                Console.WriteLine(String.Format("{0,-26}{1,7}{2,12}{3,15}",
                                  p.ProcessName, p.Id, p.SessionId, p.VirtualMemorySize64));
            }
        }

        static void KillProcess(string S)
        {
            Process[] ProcList = Process.GetProcesses();
            string ProcessName = "";
            int Id = -1;
            int okN = 0;
            int errN = 0;

            try
            {
                Id = Int32.Parse(S);
            }
            catch
            {
                ProcessName = S;
            }
            foreach (Process p in ProcList)
            {
                if (ProcessName == p.ProcessName || Id == p.Id)
                {
                    try
                    {
                        p.Kill();
                        okN++;
                    }
                    catch
                    {
                        errN++;
                    }
                }
            }
            if (ProcessName != "" || Id != -1)
            {
                if (okN > 0)
                {
                    Console.WriteLine("Завершено процессов: " + okN);
                    if (errN > 0) Console.WriteLine("Ошибок завершения процесса: " + errN);
                }
                else
                {
                    Console.WriteLine("Не найдено процессов " +
                        ((ProcessName != "") ? ("ProcessName: " + ProcessName) : "") +
                        (Id >= 0 ? "ID " + Id : ""));
                }
            }
        }

        static void Main(string[] args)
        {
            Process process = new Process();
            Process[] ProcList = Process.GetProcesses();
            string S;

            if (args.Length>0)
            {
                KillProcess(args[0]);
            }

            ShowProcessList();

            while (true)
            {
                Console.WriteLine("Для завершения процесса введите его ID или имя.");
                Console.WriteLine("Для выхода введите {0}.", "e");
                Console.WriteLine("Для вывода списка процессов введите {0}.", "p");
                Console.Write(">");
                S = Console.ReadLine();
                if (S == "e" || S == "E") break;
                if (S == "p" || S == "P") 
                    ShowProcessList();
                else 
                    KillProcess(S);
            }
        }
    }
}
