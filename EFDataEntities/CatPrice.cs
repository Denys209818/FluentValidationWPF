using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFDataEntities
{
    [Table("tblCatPrices")]
    public class CatPrice
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateCreate { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("Cat.Id")]
        public int CatId { get; set; }
        public virtual Cat Cat { get; set; }
    }
}
