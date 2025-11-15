using LibrarySystem.CLI;

namespace LibrarySystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cli = new Cli();
            cli.Run();
        }
    }
}