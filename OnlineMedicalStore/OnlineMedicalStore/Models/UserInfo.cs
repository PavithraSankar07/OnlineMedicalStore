using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore.Models
{
    public class UserInfo
    {
        //  private static int s_serialnumber = 1;
     
        // private static int s_userID = 1;
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public int WalletBalance { get; set; }
        public string Role { get; set; }

        // public UserInfo()
        // {
        //     UserID = "SF" + s_userID++;
        //     SerialNumber = s_serialnumber++;
        // }
    }
}