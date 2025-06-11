using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore.Models
{
    public class MedicineInfo
    {
        private static int s_medicineid = 1;
        public string MedicineId { get; set; }
        public string MedicineName { get; set; }
        public int MedicineCount { get; set; }
        public int MedicinePrice { get; set; }
        public DateTime ExpiryDate { get; set; } = System.DateTime.Now;

        public MedicineInfo()
        {
            MedicineId = "MID"+s_medicineid++;
        }

    }
}