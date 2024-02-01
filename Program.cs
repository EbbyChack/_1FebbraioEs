using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _1FebbraioEs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============OPERAZIONI==============");
            Console.WriteLine("Scegli l'operazione da effettuare:");
            Console.WriteLine("1.: Login");
            Console.WriteLine("2.: Logout");
            Console.WriteLine("3.: Verifica data e ora del login");
            Console.WriteLine("4.: Lista degli accessi");
            Console.WriteLine("5.: Esci");
            Console.WriteLine("========================================");

            string scelta =  Console.ReadLine();

            Utente utente1 = new Utente();

            switch (scelta)
            {
                case "1":
                    utente1.Login();
                    break;
                    
            }
            Console.ReadLine(); 
        }
    }


}
