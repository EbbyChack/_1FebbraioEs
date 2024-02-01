using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1FebbraioEs
{
    internal class Utente
    {
        public string username;
        public string password;
        public string confermaPassword;
        public bool isLoggedIn = false;

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
                Console.WriteLine("Login effetuato");
            }
            else 
            {
                Console.WriteLine("Login non riuscito");
             }
        }

        public void Logout()
        {
            if (this.isLoggedIn)
            {
                Console.WriteLine("Logout effetutato");
            }
            else 
            {
                Console.WriteLine("ERROR: l'utente non ha fatto il login");
            }
        }
    }
}
