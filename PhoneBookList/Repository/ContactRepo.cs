using PhoneBookList.Data;
using PhoneBookList.Models;

namespace PhoneBookList.Repository
{
    public class ContactRepo : IContactRepo
    {
        private readonly AppDbContext _db;
        public ContactRepo(AppDbContext db)
        {
            _db = db;
        }

        public void Create(Contact contact)
        {
            _db.contacting.Add(contact);
        }

        public void Delete(Contact contact)
        {
            _db.contacting.Remove(contact);
        }

        public IEnumerable<Contact> GetAll()
        {
            return _db.contacting;
        }

        public Contact GetById(int id)
        {
            return _db.contacting.Find(id);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Contact contact)
        {
            _db.contacting.Update(contact);
        }
    }
}
