namespace LibraryManagementSystem.Models {
    public class Book {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public bool IsAvailable { get; set; } = true;
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}