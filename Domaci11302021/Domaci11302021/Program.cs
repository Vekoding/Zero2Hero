using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Threading;

namespace Domaci11302021
{
    public class Program 
    {
        static void Main(string[] args)
        {
            RootObject rootObject = getAddress(45.25167,19.0);
            Console.WriteLine(rootObject.display_name);
            Console.WriteLine();
            DriveElevetor(12);
            DrawBuilding();
        }
        public static int DriveElevetor(int elevator)
        {
            Building investitor1 = new("Žika", 2, 5, 6);
            var writeYes = ($"Investor is : {investitor1.Investor}, Floor is : {investitor1.NumberOfFloors} Number of apartment is: {investitor1.NumberOfApartments} has elevator");
            var writeNo = ($"Investor is : {investitor1.Investor}, Floor is : {investitor1.NumberOfFloors} Number of apartment is: {investitor1.NumberOfApartments} has elevator");

            if (elevator > 4)
            {
                Console.WriteLine(writeYes);
                Console.WriteLine("You can call the elevator");
            }
            else if (elevator < 4)
            {
                Console.WriteLine(writeNo);
            }
            return elevator;
        }

        public static void DrawBuilding()
        {
            try
            {
            Again:
                int h, w, i, j;
                char twoD = '=';
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter number of floors:-");
                Console.ForegroundColor = ConsoleColor.Cyan;
                h = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter width of the Building");
                w = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Built...");
                Console.ForegroundColor = ConsoleColor.Green;

                for (i = 0; i <= h; ++i)
                {

                    for (j = 0; j <= w; j++)
                    {

                        Console.Write("|");
                        Thread.Sleep(40);
                    }
                    Console.WriteLine(twoD);
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Builded...");
                Console.WriteLine("\n=================\n");
                

                Console.WriteLine("Enjoy your stay");

                goto Again;
            }
            catch (Exception)
            {

                Console.WriteLine("Error occured");
            }
        
        }

        public static RootObject getAddress(double lat, double lon)

        {
            Console.WriteLine("Good place to start building");
            WebClient webClient = new WebClient();

            webClient.Headers.Add("user-agent", "Mozilla/4.0(compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            webClient.Headers.Add("Referer", "http://www.microsoft.com");

            var jsonData = webClient.DownloadData("http://nominatim.openstreetmap.org/reverse?format=json&lat=" + lat + "&lon=" + lon);

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(RootObject));

            RootObject rootObject = (RootObject)ser.ReadObject(new MemoryStream(jsonData));

            return rootObject;
        }
    }
}
