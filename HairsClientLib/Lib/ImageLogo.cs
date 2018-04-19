using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblImageLogo")]
   public class ImageLogo
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(maximumLength:100)]
        public string Name { get; set; }
        [Required]
        public bool Selected { get; set; }
        [Required]
        public byte[] Data { get; set; }
    }
}
