namespace LibrarySystem.CLI
{
    public class Cli
    {
        public void Run()
        {
            Console.WriteLine("Welcome to the Library System CLI!");
            Console.WriteLine("This is a placeholder for CLI functionality.");
            MainMenu();
        }

        public void MainMenu()
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. View Books");
            Console.WriteLine("2. Add Book");
            Console.WriteLine("3. Loan Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Exit");

            Console.WriteLine("Please select an option (1-5): ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ViewBooks();
                    break;
                case "2":
                    AddBook();
                    break;
                case "3":
                    LoanBook();
                    break;
                case "4":
                    ReturnBook();
                    break;
                case "5":
                    Console.WriteLine("Exiting the application. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    MainMenu();
                    break;
            }
        }


        private void ViewBooks()
        {
            Console.WriteLine("Viewing all books (functionality not yet implemented).");
            MainMenu();
        }


        private void AddBook()
        {
            Console.WriteLine("Adding a new book (functionality not yet implemented).");
            MainMenu();
        }
        private void LoanBook()
        {
            Console.WriteLine("Loaning a book (functionality not yet implemented).");
            MainMenu();
        }

        
        private void ReturnBook()
        {
            Console.WriteLine("Returning a book (functionality not yet implemented).");
            MainMenu();
        }
    }
}