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
        ExpiryDate = new DateTime(2024,11,11),
        MedicineId=1
    },
    new MedicineInfo
    {

        MedicineName = "Amoxicillin",
        MedicineCount = 10,
        MedicinePrice = 5,
        ExpiryDate = new DateTime(2026,11,11),
        MedicineId=2
    },
     new MedicineInfo
    {

        MedicineName = "Calpol",
        MedicineCount = 30,
        MedicinePrice = 45,
        ExpiryDate = new DateTime(2026,11,11),
        MedicineId=3
    },
     new MedicineInfo
    {

        MedicineName = "Gelucil",
        MedicineCount = 3,
        MedicinePrice = 40,
        ExpiryDate = new DateTime(2025,06,05),
        MedicineId=4
    },
     new MedicineInfo
    {

        MedicineName = "Metrogel",
        MedicineCount = 5,
        MedicinePrice = 50,
        ExpiryDate = new DateTime(2025,08,10),
        MedicineId=5
    },
     new MedicineInfo
    {

        MedicineName = "Povidin Iodin",
        MedicineCount = 10,
        MedicinePrice = 50,
        ExpiryDate = new DateTime(2025,11,27),
        MedicineId=6
    },
     new MedicineInfo
    {

        MedicineName = "Dolo",
        MedicineCount = 1,
        MedicinePrice = 35,
        ExpiryDate = new DateTime(2025,11,30),
        MedicineId=7
    },
};

        // Methods
        // Get
        public List<MedicineInfo> GetMedicine()
        {
            return Medicines;
        }
        // Add
        public static int id = 1;
        public bool Add(MedicineInfo medicineInfo)
        {
            if (Medicines != null)
            {

                if (Medicines.Count == 0)
                {
                    medicineInfo.MedicineId = 1;
                }
                else
                {
                    medicineInfo.MedicineId = Medicines[Medicines.Count - 1].MedicineId + 1;
               }
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

                medicine.MedicineName = medicineInfo.MedicineName;
                medicine.MedicineCount = medicineInfo.MedicineCount;
                medicine.MedicinePrice = medicineInfo.MedicinePrice;
                medicine.ExpiryDate = medicineInfo.ExpiryDate;


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