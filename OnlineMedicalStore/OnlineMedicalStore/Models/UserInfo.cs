using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore.Models
{
    public class UserInfo
    {
        
        public int UserID { get; set; }
        [Required (ErrorMessage ="Enter the valid name")]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public int WalletBalance { get; set; }
        public string Role { get; set; }

        // public UserInfo()
        // {
        //     UserID = "SF" + s_userID++;
        //     SerialNumber = s_serialnumber++;
        // }
    }
}