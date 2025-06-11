using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore.Models
{
    public class UserInfo
    {     private static int s_serialnumber = 1;
        public int  SerialNumber{ get; set; }
        private static int s_userID = 1;
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public int WalletBalance { get; set; }

        public UserInfo()
        {
            UserID = "SF" + s_userID++;
            SerialNumber = s_serialnumber++;
        }

    }
}