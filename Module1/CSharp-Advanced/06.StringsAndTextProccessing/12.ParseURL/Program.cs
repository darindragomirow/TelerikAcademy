using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            string link = Console.ReadLine();
            string protocol;
            string server;
            string resource=string.Empty;
            char[] separator = new[] { '/' };
         
            string[] parts = link.Split(separator);
            protocol = parts[0].Remove(parts[0].Length - 1);
            server = parts[2];
            for(int i=3;i<parts.Length;i++)
            {
                resource += "/" + parts[i];
                
            }
            Console.WriteLine("[protocol] = {0}",protocol);
            Console.WriteLine("[server] = 0}", server);
            Console.WriteLine("[resource] = {0}",resource );


            
        }
    }
}
