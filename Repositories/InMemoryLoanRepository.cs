using LibrarySystem.Models;
using LibrarySystem.Services;

namespace LibrarySystem.Repositories
{
    public class InMemoryLoanRepository : ILoanRepository
    {
        private readonly List<Loan> _loans = new List<Loan>();
        private int _nextId = 1;


        public IEnumerable<Loan> GetLoansByUserId(int userId)
        {
            return _loans.Where(l => l.UserId == userId);
        }

        public IEnumerable<Loan> GetLoansByBookId(int bookId)
        {
            return _loans.Where(l => l.BookId == bookId);
        }

        public void AddLoan(Loan loan)
        {
            if (loan == null)
            {
                throw new ArgumentNullException(nameof(loan));
            }
            loan.Id = _nextId++;
            _loans.Add(loan);
        }

        public Loan? GetActiveLoan(int bookId, int userId)
        {
            return _loans.FirstOrDefault(l => l.BookId == bookId && l.UserId == userId && l.ReturnDate == null);
        }
        
        public void MarkReturned(int bookId, int userId)
        {
            var loan = _loans.FirstOrDefault(l => l.BookId == bookId && l.UserId == userId && l.ReturnDate == null);
            if (loan != null)
            {
                loan.ReturnDate = DateTime.Now;
            }
        }
    }
}