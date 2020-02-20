using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ActuallEntityTest.Shared.Models {
    public class ProductModel {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
    }
}
