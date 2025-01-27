using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data
{
    [Table("inventory")]
    public class Inventory
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("product_id")]
        public Product Product { get; set; }

        [Column("store_id")]
        public Store Store { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("price"), Precision(14,2)]
        public decimal Price { get; set; }

    }
}
