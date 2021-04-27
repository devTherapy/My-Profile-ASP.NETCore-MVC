using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Models;

namespace Portfolio.Repositories
{
    public class ContactRepository : IContactRepository
    {
        public List<Contact> GetAllContacts()
        {
          var contactList =  new List<Contact>()
            {

                new Contact(1, "Email", "physionode@gmail.com"),
                new Contact(2, "Phonenumber", "+23463446333"),
                new Contact(3, "Twitter", "@Physio_dev"),
                new Contact(4, "LinkedIn", "https://www.linkedin.com/in/folusayo-abe/"),
            };

          return contactList;
        }
    }
}
