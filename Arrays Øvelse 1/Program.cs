using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Øvelse_1
{
    class Program
    {
        public static string[] Bruger = { "Root", "Bruger", "admin" };
        public static string[] Pass = { "root", "bruger24", "admindaway" };
        static void Main(string[] args)
        {
            string tryBruger, tryPass;
            int passforsøg = 3;
            int id = 0;
            bool brugerRigtig = false;
            bool passwordRigtig = false;
            do {
                Console.Clear();
                Console.WriteLine("Login");
                //tager imod og ser om din bruger findes
                Console.Write("\nBruger: ");
                tryBruger = Console.ReadLine();
                //tjekker om brugeren findes i arrayet
                for (int i = 0; i < Bruger.Length; i++)
                {
                    if (tryBruger == Bruger[i])
                    {
                        brugerRigtig = true;
                        id = i;
                    }
                }

            } while (!brugerRigtig);

            do
            {
                //ser hvilket password du skriver
                Console.Write("Passsword: ");
                tryPass = Console.ReadLine();
                //tjekker om dit password passer i arrayet
                for (int k = 0; k <= passforsøg-1; k++)
                {
                    if (tryPass == Pass[id])
                    {
                        Console.WriteLine("Hvad gør du så nu?");
                        passwordRigtig = true;
                        k = 3;
                    }
                }
            } while (!passwordRigtig);

            Console.ReadKey();
        }
    }
}
