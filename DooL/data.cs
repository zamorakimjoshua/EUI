using MooL;
using System.Reflection;
using System.Reflection.Metadata;



namespace DooL
{
    public class data
    {
        List<model> dummyAcc = new List<model>();

        public data()
        {
            CreateDummyAccount();
        }

        private void CreateDummyAccount()
        {
            model dummy1 = new model
            {
                username = "Kim",
                password = "Zamora"
            };
            model dummy2 = new model
            {
                username = "Tii",
                password = "Yab"
            };
            dummyAcc.Add(dummy1);
            dummyAcc.Add(dummy2);


        }
        public model GetAccount(string UserID)
        {
            model FoundAccount = new model();

            foreach (var dummy in dummyAcc)
            {
                if (UserID == dummy.username)
                {
                    FoundAccount = dummy;
                }

            }

            return FoundAccount;

        }
        public model GetPassword(string Password)
        {
            model FoundAccount = new model();

            foreach (var dummy in dummyAcc)
            {
                if (Password == dummy.password)
                {
                    FoundAccount = dummy;
                }

            }

            return FoundAccount;

        }
    }
}
