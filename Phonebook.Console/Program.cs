using Phonebook.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.console
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            string s;
            do
            {
                Console.WriteLine("1. Add a Contact\n2. Search Contact\n3. Edit\n4. Delete\n5. Show All Contacts\n6. Exit\nEnter your choice");
                try
                {
                    n = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a number");
                }
                Console.WriteLine();
                switch (n)
                {
                    case 1:
                        Contactbook c = new Contactbook();
                        Contact c1 = new Contact();
                        Console.WriteLine("Enter Name:");
                        c.Name = Console.ReadLine();
                        if (c.Name==null)
                        { 
                            Console.WriteLine("Name cannnot be empty");
                            break;
                        }
                        Console.WriteLine("Enter Number");
                        try
                        {
                            c.Number = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Enter only numbers");
                        }
                        c1.AddContact(c);
                        Console.WriteLine();
                        break;


                    case 2:
                        Contact c2 = new Contact();
                        Console.WriteLine("Enter name of person whose detail you want to search");
                        string nm=Console.ReadLine();
                        List<Contactbook> ps = c2.SearchContact(nm);
                        Console.WriteLine("Name          Contact Number");
                        foreach (Contactbook cb in ps)
                        {
                            Console.WriteLine("{0}             {1}", cb.Name, cb.Number);
                        }
                        break;

                    case 3:
                        Contactbook contactForEdit = new Contactbook();
                        Contact c3 = new Contact();
                        Console.WriteLine("Enter name of person whose detail you want to change");
                        s = Console.ReadLine();
                        Console.WriteLine("Enter New Name:");
                        contactForEdit.Name = Console.ReadLine();
                        if (contactForEdit.Name == null)
                        {
                            Console.WriteLine("Name cannnot be empty");
                            break;
                        }
                        Console.WriteLine("Enter New Number");
                        contactForEdit.Number = Convert.ToInt16(Console.ReadLine());
                        c3.EditContact(contactForEdit, s);
                        Console.WriteLine();
                        break;

                    case 4:
                        Contact c4 = new Contact();
                        Console.WriteLine("Enter name of person whose detail you want to delete");
                        s = Console.ReadLine();
                        c4.Delete(s);
                        Console.WriteLine();
                        break;

                    case 5:
                        Contact c5 = new Contact();
                        List<Contactbook> pd= c5.Display();
                        Console.WriteLine("Name          Contact Number");
                        foreach (Contactbook cb in pd)
                        {
                            Console.WriteLine("{0}             {1}", cb.Name, cb.Number);
                        }
                        Console.WriteLine();
                        break;

                    case 6:
                        break;

                    default:
                        Console.WriteLine("Enter Correct Choice");
                        Console.WriteLine();
                        break;
                }
            } while (n!= 6);
        }
    }
}
