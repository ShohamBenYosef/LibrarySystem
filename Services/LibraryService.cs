using LibrarySystem.Models;

namespace LibrarySystem.Services
{
    public class LibraryService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IUserRepository _userRepository;
        private readonly ILoanRepository _loanRepository;


        public LibraryService(IBookRepository bookRepository, IUserRepository userRepository, ILoanRepository loanRepository)
        {
            _bookRepository = bookRepository;
            _userRepository = userRepository;
            _loanRepository = loanRepository;
        }


        public void LoanBook(int bookId, int userId)
        {
            var book = _bookRepository.GetBookById(bookId);
            var user = _userRepository.GetUserById(userId);

            if (book == null)
            {
                throw new ArgumentException("Book not found");
            }
            if (user == null)
            {
                throw new ArgumentException("User not found");
            }
            if  (book.AvailableCopies <= 0)
            {
                throw new InvalidOperationException("No available copies of the book");
            }


            _loanRepository.AddLoan(new Loan
            {
                BookId = bookId,
                UserId = userId,
                LoanDate = DateTime.Now,
                ReturnDate = null
            });

            book.AvailableCopies--;
            _bookRepository.UpdateBook(book);
        }
    }
}