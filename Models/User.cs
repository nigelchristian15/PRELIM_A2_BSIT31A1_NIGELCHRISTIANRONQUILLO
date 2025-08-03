using System.Collections.Generic;
namespace LibraryManagementSystem.Models {
    public class User {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new();
    }
}