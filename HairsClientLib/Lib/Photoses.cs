using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblPhotoses")]
    public class Photoses
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DateOfCreate { get; set; }
        [Required,StringLength(maximumLength:100)]
        public string Name { get; set; }
        [Required]
        public byte[] Photo { get; set; }
    }
}
