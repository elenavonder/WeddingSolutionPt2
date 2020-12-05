using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingProject2.Models
{
    public class Products
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string PartNbr { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName = "decimal (11,2)")]
        public decimal Price { get; set; }
        [Required]
        [StringLength(30)]
        public string Unit { get; set; } = "each";
        [StringLength(255)]
        public string PhotoPath { get; set; }
        public int VendorId { get; set; }
        public virtual Vendors Vendor { get; set; }

        public Products()
        {
        }
    }
}
