using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace проводник3
{
        static class explorer
        {
            public static int i = 0;
            public static void Final()
            {

                string A = Info();
                string B = Ways(A);
            }



            public static string Info()
            {
                Console.SetCursorPosition(50, 0);
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                Console.SetCursorPosition(0, 3);
                foreach (DriveInfo d in allDrives)
                {
                    BigInteger a = d.TotalFreeSpace;
                    a /= 1073741824;
                    BigInteger b = d.TotalSize;
                    b /= 1073741824;

                    Console.WriteLine($"  {d.Name} {a} из {b}");
                }
                strelochki str = new strelochki(2, allDrives.Length + 1);
                int position = str.Strelka() - 2;
                return allDrives[position].Name;
            }

            static private string Ways(string name)
            {
                int file = 0;

                List<string> allData = new List<string>();
                  
                var WayInfo = new DirectoryInfo(name);

                if (name.Contains("."))
                {

                    Process.Start(new ProcessStartInfo { FileName = name, UseShellExecute = true });
                    return "  ";
                }

                string[] allDirectories = Directory.GetDirectories(name);
                string[] allFiles = Directory.GetFiles(name);
                allData.AddRange(allDirectories);
                allData.AddRange(allFiles);
                allData.Sort();
               

                foreach (string datas in allData)
                {
                    Console.WriteLine($" {datas}");
                    Console.SetCursorPosition(50, file + 2);
                    Console.WriteLine($"{WayInfo.CreationTime} ");
                    file++;
                }
                strelochki menu = new strelochki(2, file);
                int position34 = menu.Strelka() - 2;

                if (position34 == -1007)
                {
                    Console.Clear();
                    return " ";
                }
                return Ways(allData[position34]);
            }
        }
    }


