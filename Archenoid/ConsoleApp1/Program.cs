using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("merhaba efendim , Ben Archenoid size nasıl yardımcı olabilirim");
            while (true)
            { 
                string kullanicitus;
                kullanicitus = Console.ReadLine();

                if (kullanicitus == "!komutlist")
                {
                    Console.WriteLine("komutlar : kapat , belgeleri aç , resimleri aç , c diskini aç , d diskini aç , e diskini aç , pp klasörümü aç;");
                }
                
                else if (kullanicitus == "kapat")
                {
                    Console.WriteLine("bilgisayarı kapatıyorum efendim");
                    Thread.Sleep(2000);
                    System.Diagnostics.Process.Start("shutdown", "-f -s -t 1");
                }
                
                else if (kullanicitus == "belgeleri aç")
                {
                    System.Diagnostics.Process.Start("explorer.exe", @"c:\documents");
                    Console.WriteLine("belgelerinizi açtım efendim");
                }

                
                else if (kullanicitus == "resimleri aç")
                {
                    System.Diagnostics.Process.Start("explorer.exe", @"C:\Users\rasitxd\Pictures");
                    Console.WriteLine("Resimlerinizi açtım efendim");
                }
                                
                else if (kullanicitus == "c diskini aç")
                {
                    System.Diagnostics.Process.Start("explorer.exe", @"C:\");
                    Console.WriteLine("C diskini açtım efendim");
                }
            
                else if (kullanicitus == "d diskini aç")
                {
                    System.Diagnostics.Process.Start("explorer.exe", @"D:\");
                    Console.WriteLine("D diskini açtım efendim");
                }
            
                else if (kullanicitus == "e diskini aç")
                {
                    System.Diagnostics.Process.Start("explorer.exe", @"E:\");
                    Console.WriteLine("E diskini açtım efendim");
                }

                else if (kullanicitus == "pp klasörümü aç")
                {
                    System.Diagnostics.Process.Start("explorer.exe", @"E:\folders\gifpp");
                    Console.WriteLine("PP klasörünüzü açtım efendim");
                }

                else
                {
                    Console.WriteLine("anlayamadım efendim");
                }


                
            }




        }
    }
}
