using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore.Models
{
    public class OrderInfo
    {private static int s_serialnumber = 1;
        public int  SerialNumber{ get; set; }
        private static int s_orderid = 1;
        public string OrderID { get; set; }
        public string MedicineName { get; set; }
        public string MedicineID { get; set; }
        public string UserID { get; set; }
        public int TotalPrice { get; set; }
        public int MedicineCount { get; set; }
        public string PurchaseStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderInfo()
        {
            OrderID = "OID" + s_orderid++;
            SerialNumber = s_serialnumber++;
        }
    }
}