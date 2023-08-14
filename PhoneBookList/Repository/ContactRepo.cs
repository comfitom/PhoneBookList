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
            _db.contactings.Add(contact);
        }

        public void Delete(Contact contact)
        {
            _db.contactings.Remove(contact);
        }

        public IEnumerable<Contact> GetAll()
        {
            return _db.contactings;
        }

        public Contact GetById(int id)
        {
            return _db.contactings.Find(id);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Contact contact)
        {
            _db.contactings.Update(contact);
        }
    }
}
