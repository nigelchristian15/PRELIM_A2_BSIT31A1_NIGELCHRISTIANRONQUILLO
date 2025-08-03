using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem.Controllers {
    public class LibraryController : Controller {
        static List<Author> authors = new() {
            new Author { Id = 1, Name = "J.R.R. Tolkien" },
            new Author { Id = 2, Name = "H.K. Rowling" },
            new Author { Id = 3, Name = "Ozzy Osbourne" }
        };

        static List<Book> books = new() {
            new Book { Id = 1, Title = "LOTR", Genre = "Kids", IsAvailable = true, Author = authors[0] },
            new Book { Id = 2, Title = "Harry Puto", Genre = "Scifi", IsAvailable = true, Author = authors[1] },
            new Book { Id = 3, Title = "Prince of Darkness", Genre = "Kids", IsAvailable = true, Author = authors[2] }
        };

        public IActionResult Index() {
            return View(books);
        }

        public IActionResult Borrow(int id) {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null && book.IsAvailable) {
                book.IsAvailable = false;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Return(int id) {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null) {
                book.IsAvailable = true;
            }
            return RedirectToAction("Index");
        }
    }
}