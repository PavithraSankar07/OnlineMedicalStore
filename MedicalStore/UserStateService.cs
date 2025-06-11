using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalStore.Models;

namespace MedicalStore
{
    public class UserStateService
    {
        public List<UserInfo> Users { get; set; } = new List<UserInfo>
    {
        new UserInfo
        {
            UserID = "1",
            Name = "Pavi",
            Email = "pavi@gmail.com",
            Password = "123",
            MobileNumber = "1234567890",
            WalletBalance = 1000
        },
        new UserInfo
        {
            UserID = "2",
            Name = "Ravi",
            Email = "ravi@gmail.com",
            Password = "123",
            MobileNumber = "0987654321",
            WalletBalance = 2000
        }

    };


        public UserInfo? CurrentUser { get; set; }

        public List<MedicineInfo> Medicines { get; set; } = new List<MedicineInfo>
{
    new MedicineInfo
    {

        MedicineName = "Paracetamol",
        MedicineCount = 50,
        MedicinePrice = 20,
        ExpiryDate = new DateTime(2024,11,11)
    },
    new MedicineInfo
    {

        MedicineName = "Amoxicillin",
        MedicineCount = 10,
        MedicinePrice = 5,
        ExpiryDate = new DateTime(2026,11,11)
    },
     new MedicineInfo
    {

        MedicineName = "Calpol",
        MedicineCount = 30,
        MedicinePrice = 45,
        ExpiryDate = new DateTime(2026,11,11)
    },
     new MedicineInfo
    {

        MedicineName = "Gelucil",
        MedicineCount = 3,
        MedicinePrice = 40,
        ExpiryDate = new DateTime(2025,06,05)
    },
     new MedicineInfo
    {

        MedicineName = "Metrogel",
        MedicineCount = 5,
        MedicinePrice = 50,
        ExpiryDate = new DateTime(2025,08,10)
    },
     new MedicineInfo
    {

        MedicineName = "Povidin Iodin",
        MedicineCount = 10,
        MedicinePrice = 50,
        ExpiryDate = new DateTime(2025,11,27)
    },
     new MedicineInfo
    {

        MedicineName = "Dolo",
        MedicineCount = 1,
        MedicinePrice = 35,
        ExpiryDate = new DateTime(2025,11,30)
    },
};
        public List<OrderInfo> Orders { get; set; } = new List<OrderInfo>();

    }
}