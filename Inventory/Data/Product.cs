using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data
{
    [Table("products")]
    public class Product
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column(Order = 0)]
        public string Name { get; set; }

        [Column(Order = 1), Precision(14 ,2)]
        public decimal Price { get; set; }
    }
}
