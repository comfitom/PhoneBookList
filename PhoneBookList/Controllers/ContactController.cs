using Microsoft.AspNetCore.Mvc;
using PhoneBookList.Data;
using PhoneBookList.Models;
using PhoneBookList.Repository;

namespace PhoneBookList.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepo _contactRepo;
        public ContactController(IContactRepo contactRepo)
        {
            _contactRepo = contactRepo;
        }
        public IActionResult Index()
        {
            var contacts = _contactRepo.GetAll();
            return View(contacts);
        }
        public IActionResult Create ()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Contact contact)
        {
            if(contact.FirstName == contact.LastName)
            {
                ModelState.AddModelError("CustomError", "First Name And Last Name Cannot Be Exactly The Same!!!");
            }
            if(ModelState.IsValid)
            {
                _contactRepo.Create(contact);
                _contactRepo.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        //GET
        public IActionResult Update(int Id)
        {
            var findId = _contactRepo.GetById(Id);
            return View(findId);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Contact contact)
        {
            if (contact.FirstName == contact.LastName)
            {
                ModelState.AddModelError("CustomError", "First Name And Last Name Cannot Be Exactly The Same!!!");
            }
            if (ModelState.IsValid)
            {
                _contactRepo.Update(contact);
                _contactRepo.Save();
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        //GET
        public IActionResult Delete(int Id)
        {
            var findId = _contactRepo.GetById(Id);
            return View(findId);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Contact contact)
        {
            if (contact != null)
            {
                _contactRepo.Delete(contact);
                _contactRepo.Save();
                return RedirectToAction("Index");
            }
            return View(contact);
        }
    }

}
