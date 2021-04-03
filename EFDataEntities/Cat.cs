using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataEntities
{
    [Table("tblCats")]
    public class Cat
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public bool Gender { get; set; }
        [Required, StringLength(4000)]
        public string Details { get; set; }
        [Required]
        public string imgPath { get; set; }
        public virtual ICollection<CatPrice> CatPrices { get; set; }
    }
}
