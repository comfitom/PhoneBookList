using PhoneBookList.Models;

namespace PhoneBookList.Repository
{
    public interface IContactRepo
    {
        IEnumerable<Contact> GetAll();
        Contact GetById(int id);
        void Create(Contact contactList);
        void Update(Contact contact);
        void Delete(Contact contact);
        void Save();
    }
}
