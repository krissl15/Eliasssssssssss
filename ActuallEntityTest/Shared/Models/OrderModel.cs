using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ActuallEntityTest.Shared.Models {
    public class OrderModel {
        [Key]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public CustomerModel Customer { get; set; }
        public ICollection<ProductOrderModel> ProductOrders { get; set; }
    }
}
