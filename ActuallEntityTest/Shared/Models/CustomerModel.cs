using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ActuallEntityTest.Shared.Models {
   public class CustomerModel {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public ICollection<OrderModel> Orders { get; set; }
    }
}