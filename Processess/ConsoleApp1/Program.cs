using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My Programm";


            bool flag = true;
            while (flag)
            {
                Console.Clear();

                Console.WriteLine("Exit - 0");
                Console.WriteLine("Process - 1");
                Console.Write("Open Opera - 2\n\nChoose -> ");

                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        {
                            Console.Clear();

                            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\tGoodbye:)");
                            flag = false;

                            break;
                        }
                    case 1:
                        Console.Clear();

                        foreach (var process in Process.GetProcesses())
                        {
                            double gb = process.VirtualMemorySize64 / 1073741824.0;
                            TimeSpan workingTime = Process.GetCurrentProcess().TotalProcessorTime;

                            Console.WriteLine($"Name: {process.ProcessName} | Id: {process.Id} | Priority: {Process.GetCurrentProcess().PriorityClass.ToString()}\nOccupied memory in the processor: {Math.Round(gb, 3)} GB | Working time: {workingTime.Milliseconds} millseconds\n");
                        }

                        Console.ReadKey();

                        break;

                    case 2:
                        {
                            Console.Clear();

                            Process proccess = new Process();
                            proccess.StartInfo.FileName = "opera.exe";

                            proccess.Start();
                            Console.WriteLine("Process Started");
                            proccess.WaitForExit();
                            proccess.Close();
                            Console.WriteLine("Process Ended");

                            Console.ReadKey();

                            break;
                        }

                    default:
                        {
                            Console.Clear();

                            Console.WriteLine("Wrong input!!!");
                            Thread.Sleep(2000);

                            break;
                        }
                }
            }
        }
    }
}