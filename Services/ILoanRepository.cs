using LibrarySystem.Models;

namespace LibrarySystem.Services
{
    public interface ILoanRepository
    {
        IEnumerable<Loan> GetLoansByUserId(int userId);
        IEnumerable<Loan> GetLoansByBookId(int bookId);
        void AddLoan(Loan loan);
        Loan? GetActiveLoan(int bookId);
    }
}