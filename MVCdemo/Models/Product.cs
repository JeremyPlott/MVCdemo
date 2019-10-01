using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCdemo.Models {

    public class Product {

        public int ProductId { get; set; }

        [StringLength(80)]
        public string Description { get; set; }

        [Range(0,1000)]
        public int QtyOnHand { get; set; }

        [Range(0,1000)]
        public int? ReorderPoint { get; set; }

        [StringLength(8)]
        public string Status { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal Cost { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal Price { get; set; }

        [ForeignKey]
        public Vendor VendorId { get; set; }

    }
}