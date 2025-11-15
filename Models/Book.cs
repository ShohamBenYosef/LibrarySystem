using LibrarySystem.Utils;

namespace LibrarySystem.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public Category Category { get; set; }
        public  int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
    }
}