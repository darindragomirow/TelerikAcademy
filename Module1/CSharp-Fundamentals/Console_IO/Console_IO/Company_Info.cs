using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_IO
{
    class Company_Info
    {
        static void Main(string[] args)
        {
            //Input
            string companyName = (Console.ReadLine());
            string companyAdress = (Console.ReadLine());
            string phone = (Console.ReadLine());
            string fax = (Console.ReadLine());
            string website = (Console.ReadLine());
            string firstName = (Console.ReadLine());
            string lastName = (Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string mgPhone = (Console.ReadLine());
            //Output
            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAdress);
            Console.WriteLine("Tel. "+phone);
            if (fax == "")
            {
                Console.WriteLine("Fax: (no fax)");
            }else
            {
                Console.WriteLine("Fax: "+fax);
            }
            Console.WriteLine("Web site: "+website);
            Console.WriteLine("Manager: "+firstName+" "+lastName+" "+"(age: "+age+", "+"tel. "+mgPhone+")");
        }
    }
}
