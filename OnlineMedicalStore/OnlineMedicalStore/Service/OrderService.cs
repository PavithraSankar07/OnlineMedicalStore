using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineMedicalStore.Models;

namespace OnlineMedicalStore.Service
{
    public class OrderService
    {
        public readonly UserService _userService;
        public readonly MedicineService _medicineService;
        public static List<OrderInfo> orders = new();

        public List<OrderInfo> GetOrders()
        {
            return orders;
        }
        public bool AddOrder(OrderInfo order)
        {
            if (order != null)
            {
                if (orders.Count != 0)
                {
                    order.OrderID = orders[orders.Count - 1].OrderID + 1;
                }
                else
                {
                    order.OrderID = 1;
                }
                orders.Add(order);
                return true;
            }
            return false;
        }


    }
}