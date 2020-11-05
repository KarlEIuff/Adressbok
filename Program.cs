using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbok
{
    class Program
    {

        class PersonInfo
        {
            public string namn, adress, telefon, email;

            public PersonInfo(string arg1, string arg2, string arg3, string arg4)
            {
                namn = arg1;
                adress = arg2;
                telefon = arg3;
                email = arg4;
            }
        }

        static void Main(string[] args)
        {
            List<string> infoLista = new List<string>();
            bool checker = false;
            Console.WriteLine("Välkommen till adressboken" +
                              "\nVad vill du göra?" +
                              "\nKommandon: ['add', 'remove', 'save']");

            do
            {
                Console.Write("> ");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "add":
                        break;
                    case "remove":
                        break;
                    case "save":
                        break;
                    default:
                        break;
                }
            } while (!checker);
        }
    }
}
