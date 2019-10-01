using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCdemo.Models {

    public class Vendor {

        public int VendorId { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        [Required]
        [StringLength(8)]
        public string Status { get; set; }

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$")]
        [Required]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
