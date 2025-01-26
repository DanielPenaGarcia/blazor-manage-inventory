using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Data
{
    [Table("codes_verifications")]
    public class CodeAdminRegister
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("code")]
        [Required]
        [MaxLength(100)]
        public string Code { get; set; }

        [Column("used")]
        public bool Used { get; set; }
    }
}
