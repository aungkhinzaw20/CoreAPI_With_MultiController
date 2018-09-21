using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using ContactsAPI.Model;
using ContactsAPI.Repository;

namespace ContactsAPI.Controllers
{
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        public IContactsRepository ContactsRepository { get; set; }
        public ContactsController(IContactsRepository _contactsRepository)
        {
            ContactsRepository = _contactsRepository;
        }

        [HttpGet]
        public IEnumerable<Contacts> GetAll()
        {
            return ContactsRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetContacts")]
        public IActionResult GetContacts(string id)
        {
            var item = ContactsRepository.Find(id);
            if (item == null)
                return NotFound();

            return new ObjectResult(item);
        }
        [HttpPost]
        public IActionResult Create([FromBody] Contacts item)
        {
            if (item==null)
                return BadRequest();
            var ContacttoAdd = ContactsRepository.Find(item.Email);
            if (ContacttoAdd !=null)
            {
                return StatusCode(403);
            }
            ContactsRepository.Add(item);
            return CreatedAtRoute("GetContacts", new { Controller = "Contacts", id = item.Email }, item);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var ContactsToDelete = ContactsRepository.Find(id);
            if (ContactsToDelete==null)
            {
                return NotFound();
            }
            ContactsRepository.Remove(id);
            return new OkResult();
        }
        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] Contacts item)
        {
            if (item == null)
                return BadRequest();
            var ContactstoUpdate = ContactsRepository.Find(id);
            if (ContactstoUpdate == null)
                return NotFound();
            ContactsRepository.Update(item);
            return new OkResult();
        }
    }
}
