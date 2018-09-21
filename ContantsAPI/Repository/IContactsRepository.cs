using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsAPI.Model;
namespace ContactsAPI.Repository
{
    public interface IContactsRepository
    {
        void Add(Contacts item);
        IEnumerable<Contacts> GetAll();
        Contacts Find(string key);
        void Remove(string id);
        void Update(Contacts item);
    }
}
