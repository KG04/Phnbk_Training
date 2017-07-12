using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Library
{

    public interface ContactDetails
    {
        void AddContact(Contactbook c);
        List<Contactbook> SearchContact(String nm);
        void EditContact(Contactbook c, string s);
        void Delete(String nm);
        List<Contactbook> Display();
    }

    //
    public class Contact
    {
        static List<Contactbook> P = new List<Contactbook>();

        public void AddContact(Contactbook c)
        {
            P.Add(c);
        }

        public List<Contactbook> SearchContact(String nm)
        {
            int cnt = P.Count;
            return P.Where(per => per.Name == nm).ToList();
        }

        public void EditContact(Contactbook c, string s)
        {
            foreach (Contactbook cb in P)
            {
                if (cb.Name == s)
                {
                    cb.Name = c.Name;
                    cb.Number = c.Number;
                }
            }
        }

        public void Delete(String nm)
        {
            var contacts = P.Where(con => con.Name == nm).ToList();
            foreach (var contact in contacts)
            {
                P.Remove(contact);
            }
        }

        public List<Contactbook> Display()
        {
            return P;
        }
    }
    
}
