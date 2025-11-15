using LibrarySystem.Models;
using LibrarySystem.Services;

namespace LibrarySystem.Repositories
{
    public class InMemoryBookRepository : IBookRepository
    {
        private readonly List<Book> _books = new List<Book>();
        private int _nextId = 1;

        public void AddBook(Book book)
        {   
            if (_books.Any(b => b.Id == book.Id))
            {
                throw new ArgumentException("A book with the same ID already exists.");
            }
            
            book.Id = _nextId++;
            _books.Add(book);
        }

        public Book GetBookById(int id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }


        public void DeleteBook(int id)
        {
            _books.RemoveAll(b => b.Id == id);
        }

        public void UpdateBook(Book updatedBook)
        {
            var index = _books.FindIndex(b => b.Id == updatedBook.Id);
            if (index != -1) _books[index] = updatedBook;
        }
    }
}