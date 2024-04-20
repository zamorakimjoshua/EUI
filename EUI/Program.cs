using BooL;

namespace EUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter UserID:");
            string UserID = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string Password = Console.ReadLine();

            Book DataService = new Book();
            bool result = DataService.VerifyUserID(UserID);

            Book PasswordService = new Book();
            bool result1 = PasswordService.VerifyPassword(Password);

            if (result1 && result)
            {
                Console.WriteLine("Login Successfully");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }
        }
    }
}
