using System.Collections.Generic;
using Portfolio.Models;

namespace Portfolio.Repositories
{
    /// <summary>
    /// returns a list of my contacts
    /// </summary>
    public interface IContactRepository
    {
        List<Contact> GetAllContacts();
    }
}