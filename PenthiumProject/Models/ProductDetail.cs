namespace PenthiumProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductDetail")]
    public partial class ProductDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal ProductPrice { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ProductDescription { get; set; }

        public bool? ProductStock { get; set; }

        public bool? ProductLike { get; set; }

        [StringLength(50)]
        public string ProductImage { get; set; }

        public virtual Product Product { get; set; }
    }
}
