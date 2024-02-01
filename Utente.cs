using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1FebbraioEs
{
    internal class Utente
    {
        private string username;
        private string password;
        private string confermaPassword;
        private bool isLoggedIn = false;

        public void Login()
        {
            Console.WriteLine("Inserisci username: ");
            this.username = Console.ReadLine();
            Console.WriteLine("Inserisci password");
            this.password = Console.ReadLine();
            Console.WriteLine("Conferma password");
            this.confermaPassword = Console.ReadLine();

            if (this.password == this.confermaPassword && this.username != " ")
            {
                this.isLoggedIn = true;
                Console.WriteLine("\nLogin effetuato");
            }
            else 
            {
                Console.WriteLine("\nLogin non riuscito");
             }
        }

        public void Logout( )
        {
            if (this.isLoggedIn)
            {
                this.isLoggedIn = false;
                Console.WriteLine("Logout effetutato");
            }
            else 
            {
                Console.WriteLine("ERROR: l'utente non ha fatto il login");
            }


        }

        public bool IsLoggedIn()
        {
            return this.isLoggedIn;
        }
    }

}
