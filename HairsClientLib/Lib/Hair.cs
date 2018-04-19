using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblHair")]
    public class Hair
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Width { get; set; }
        [Required]
        public int x1 { get; set; }
        [Required]
        public int y1 { get; set; }
        [Required]
        public int x2 { get; set; }
        [Required]
        public int y2 { get; set; }
    }
}
