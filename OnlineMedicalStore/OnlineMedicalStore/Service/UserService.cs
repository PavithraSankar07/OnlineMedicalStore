
using OnlineMedicalStore.Models;

namespace OnlineMedicalStore.Service
{
    public class UserService
    {
        // Create the list and add it default data
        public static List<UserInfo> users = new()
        {
               new UserInfo
               {
                //  UserID = "1",
                Name = "Pavi",
                Email = "pavi@gmail.com",
                Password = "123",
                MobileNumber = "1234567890",
                WalletBalance = 1000,
                Role="Admin"
               }
        };
        //Set current user
        // public UserInfo? CurrentUser { get; set; }

        public UserInfo Login(string email, string password)
        {
            var user = users.Find(u => email == u.Email && password == u.Password);
            if (user != null)
            {
                return user;
            }
            return default;
        }
        public bool NewUser(UserInfo userInfo)

        {

            var user = users.Find(u => userInfo.Email == u.Email);

            if (user == null)
            {
                if (users.Count != 0)
                {
                    userInfo.UserID = users[users.Count - 1].UserID + 1;
                }
                else
                {
                    userInfo.UserID = 1;
                }
                userInfo.Role = "User";
                users.Add(userInfo);
                return true;
            }
            return false;
        }
        public UserInfo GetUser(string mailid)
        {
            var user = users.Find(u => u.Email == mailid);
            if (user != null)
            {
                return user;
            }
            return default;
        }
          public void UpdateWalletBalance(string mailID, int amount)
        {
            var user = users.Find(e => e.Email == mailID);
            user.WalletBalance += amount;
        }
        
    }
}