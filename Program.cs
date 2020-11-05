using System;
using System.Collections.Generic;
using System.IO;
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
            List<PersonInfo> personer = new List<PersonInfo>();
            bool checker = false;
            string filePath = "C:\\Users\\k_eer\\adressbok.txt";
            string[] fileContent = File.ReadAllLines(filePath);
            
            for(int i = 0; i < fileContent.Length; i++)
            {
                string dummy = fileContent[i];
                string[] dummyArray = dummy.Split(' ');
                PersonInfo P = new PersonInfo(dummyArray[0], dummyArray[1], dummyArray[2], dummyArray[3]);
            }

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
