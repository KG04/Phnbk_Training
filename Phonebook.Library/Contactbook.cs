using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Library
{
    public class Contactbook
    {
        private string myName = "N/A";
        private int myNumber = 0;

        public string Name
        {
            get
            {
                return myName;
            }
            set
            {
                myName = value;
            }
        }

        public int Number
        {
            get
            {
                return myNumber;
            }
            set
            {
                myNumber = value;
            }
        }
    }
}
