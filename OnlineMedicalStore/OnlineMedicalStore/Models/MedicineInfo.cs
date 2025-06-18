using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore.Models
{
    public class MedicineInfo
    {
        
     
        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public int MedicineCount { get; set; }
        public int MedicinePrice { get; set; }
        public DateTime ExpiryDate { get; set; } = System.DateTime.Now;

       
    }
}