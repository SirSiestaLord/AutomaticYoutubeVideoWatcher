using System;
using System.Diagnostics;
using
System.Threading;
namespace AutomaticYoutubeVideoWatcher
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] links = new string[100];
            float[] times = new float[100];
            int i = 0, workcounter;
            for (int x = 0; x < 1; x = x)
            {
                Console.WriteLine("\n1-)Add Youtube Link\n2-)Start the Process\n");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        {
                            Console.WriteLine("Link:");
                            links[i] = Console.ReadLine();

                            Console.WriteLine("End Time(as second):");
                            times[i] = float.Parse(Console.ReadLine());
                            i++;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("How many times should repeat ?:");
                            workcounter = int.Parse(Console.ReadLine());
                            for (int y = 0; y < i; y++)
                            {


                                for (int k = 0; k < workcounter; k++)
                                {
                                    Process process = new Process();
                                    process.StartInfo.UseShellExecute = true;
                                    process.StartInfo.FileName = "chrome";
                                    process.StartInfo.Arguments = links[y];
                                    process.StartInfo.CreateNoWindow = true;
                                    process.Start();
                                    int a = (int)times[y] * 1000;
                                    Thread.Sleep(a);
                                    process.Kill();

                                }
                            }
                            break;
                        }
                    default: { Console.WriteLine("Please choose from menu variables.\n"); break; }
                }
            }

        }
    }
}
