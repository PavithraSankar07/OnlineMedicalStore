using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore.Models
{
    public class OrderInfo
    {
        

        public int OrderID { get; set; }
        public string MedicineName { get; set; }
        public int MedicineID { get; set; }
        public int UserID { get; set; }
        public int TotalPrice { get; set; }
        public int MedicineCount { get; set; }
        public string PurchaseStatus { get; set; }
        public DateTime OrderDate { get; set; }
    }
}