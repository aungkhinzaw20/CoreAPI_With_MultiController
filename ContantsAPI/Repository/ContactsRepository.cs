using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsAPI.Model;

namespace ContactsAPI.Repository
{
    public class ContactsRepository : IContactsRepository
    {
        static List<Contacts> ContactsList = new List<Contacts>();
        public void Add(Contacts item)
        {
            ContactsList.Add(item);

        }

        public Contacts Find(string key)
        {
            return ContactsList.Where(x => x.Email.Equals(key)).SingleOrDefault();
        }

        public IEnumerable<Contacts> GetAll()
        {
            return ContactsList;
        }

        public void Remove(string id)
        {
            var itemtoremove = ContactsList.SingleOrDefault(r => r.Email.Equals(id));
            if (itemtoremove !=null)
            {
                ContactsList.Remove(itemtoremove);
            }
        }

        public void Update(Contacts item)
        {
            var itemtoUpdate = ContactsList.SingleOrDefault(x => x.Email.Equals(item));
            if (itemtoUpdate != null)
            {
                itemtoUpdate.Company = item.Company;
                itemtoUpdate.Name = item.Name;
            }
        }
    }
}
