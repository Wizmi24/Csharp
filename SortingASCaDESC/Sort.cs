using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingASCaDESC
{
    public class Sort
    {
        public string[] SortContacts(string[] contacts, string option)
        {
            Func<string, string> getLastName = name => name.Split(" ")[1];
            if(option == "ASC")
            {
                return contacts.OrderBy(getLastName).ToArray();
            }
            else
            {
                return contacts.OrderByDescending(getLastName).ToArray();
            }
        }
    }
}
