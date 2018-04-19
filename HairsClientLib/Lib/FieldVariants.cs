using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblFieldVariants")]
   public class FieldVariants
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(maximumLength:100)]
        public string NameAndina { get; set; }
        [Required]
        public bool Selected { get; set; }
        [Required, StringLength(maximumLength: 2000)]
        public string Text { get; set; }
    }
}
