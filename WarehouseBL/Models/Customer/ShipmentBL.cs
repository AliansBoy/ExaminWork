﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Models.Employee;

namespace WarehouseBL.Models.Customer
{
    public class ShipmentBL : BaseModelBL
    {
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? DeliveryDate { get; set; }

        public CustomerBL Customer { get; set; }
        public EmployeeBL Employee { get; set; }
        public IEnumerable<ProductShipmentBL> ProductShipments { get; set; }
    }
}
