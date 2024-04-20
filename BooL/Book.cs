using DooL;
using MooL;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BooL
{
    public class Book
    {
        public bool VerifyUserID(string username)
        {
            data datas = new data();
            var result = datas.GetAccount(username);

            return result.username != null ? true : false;
        }
        public bool VerifyPassword(string password)
        {
            data passwords = new data();
            var result = passwords.GetPassword(password);

            return result.password != null ? true : false;
        }
    }
}
