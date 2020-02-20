using System;
using System.Collections.Generic;
using System.Text;

namespace ActuallEntityTest.Shared.Models {
    public class ProductOrderModel {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public OrderModel Order { get; set; }
        public ProductModel Product { get; set; }


    }
}
