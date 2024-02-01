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
        static Utente utente1 = new Utente();
        static void Main(string[] args)
        {
            
            menu();
        }
        public static void menu()
        {
            Console.WriteLine("===============OPERAZIONI==============");
            Console.WriteLine("Scegli l'operazione da effettuare:");
            Console.WriteLine("1.: Login");
            Console.WriteLine("2.: Logout");
            Console.WriteLine("3.: Verifica data e ora del login");
            Console.WriteLine("4.: Lista degli accessi");
            Console.WriteLine("5.: Esci");
            Console.WriteLine("========================================");

            string scelta = Console.ReadLine();

            

            switch (scelta)
            {
                case "1":
                    utente1.Login();
                    break;
                case "2":
                    utente1.Logout();
                    break;

            }
            menu();
            Console.ReadLine();
        }
    }


}
