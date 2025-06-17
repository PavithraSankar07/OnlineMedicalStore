using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineMedicalStore.Models;

namespace OnlineMedicalStore.Service
{
    public class MedicineService
    {
        // List with default data
        public static List<MedicineInfo> Medicines { get; set; } = new List<MedicineInfo>
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

        // Methods
        // Get
        public List<MedicineInfo> GetMedicine()
        {
            return Medicines;
        }
        // Add
        public bool Add(MedicineInfo medicineInfo)
        {
            if (Medicines != null)
            {
                Medicines.Add(medicineInfo);
                return true;
            }
            return false;
        }
        // Edit
        public bool Edit(MedicineInfo medicineInfo)
        {
            MedicineInfo medicine = Medicines.Find(u => u.MedicineId == medicineInfo.MedicineId);
            if (medicine != null)
            {
                medicineInfo = new MedicineInfo()
                {
                    MedicineName = medicineInfo.MedicineName,
                    MedicineCount = medicineInfo.MedicineCount,
                    MedicinePrice = medicineInfo.MedicinePrice,
                    ExpiryDate = medicineInfo.ExpiryDate

                };
                return true;
            }
            return false;
        }
        // Delete
        public bool Delete(MedicineInfo medicineInfo)
        {
            MedicineInfo medicine = Medicines.Find(u => u.MedicineId == medicineInfo.MedicineId);
            if (medicine != null)
            {
                Medicines.Remove(medicine);
                return true;
            }
            return false;
        }

    }
}