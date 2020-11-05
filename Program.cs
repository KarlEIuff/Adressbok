using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                string[] dummyArray = dummy.Split(',');
                PersonInfo P = new PersonInfo(dummyArray[0], dummyArray[1], dummyArray[2], dummyArray[3]);
                personer.Add(P);
            }

            Console.WriteLine("Välkommen till adressboken");
                              

            do
            {
                Console.WriteLine("\nVad vill du göra?" +
                                  "\nKommandon: ['add', 'show', 'remove', 'save', 'quit']");
                Console.Write("> ");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "add":
                        string[] nyPersonArr = AddPerson();
                        PersonInfo nyPerson = new PersonInfo(nyPersonArr[0], nyPersonArr[1], nyPersonArr[2], nyPersonArr[3]);
                        personer.Add(nyPerson);
                        break;
                    case "show":
                        for (int i = 0; i < personer.Count; i++)
                        {
                            Console.WriteLine(i + 1 + ": " + personer[i].namn + ", " + personer[i].adress + ", " + personer[i].telefon + ", " + personer[i].email);
                        }
                        break;
                    case "remove":
                        Console.WriteLine("Vilken position vill du ta bort?");
                        Console.Write("> ");
                        string sRemovePos = Console.ReadLine();
                        int removePos = int.Parse(sRemovePos);
                        personer.RemoveAt(removePos - 1);
                        break;
                    case "save":
                        File.WriteAllText(filePath, "");
                        using(StreamWriter sw = File.CreateText(filePath))
                        {
                            for (int i = 0; i < personer.Count; i++)
                            {
                                string[] dummy = new string[4];
                                dummy[0] = personer[i].namn;
                                dummy[1] = personer[i].adress;
                                dummy[2] = personer[i].telefon;
                                dummy[3] = personer[i].email;
                                string fullText = dummy[0] + ", " + dummy[1] + ", " + dummy[2] + ", " + dummy[3];
                                sw.WriteLine(fullText);
                            }
                        }
                        break;
                    case "quit":
                        checker = true;
                        break;
                    default:
                        Console.WriteLine("Detta kommando finns inte!\nFörsök igen");
                        break;
                }
            } while (!checker);
        }

        public static string[] AddPerson()
        {
            string[] dummy = new string[4];
            Console.Write("Ange namn: ");
            dummy[0] = Console.ReadLine();
            Console.Write("Ange adress: ");
            dummy[1] = Console.ReadLine();
            Console.Write("Ange telefon: ");
            dummy[2] = Console.ReadLine();
            Console.Write("Ange email: ");
            dummy[3] = Console.ReadLine();
            return dummy;
        }

    }
}
