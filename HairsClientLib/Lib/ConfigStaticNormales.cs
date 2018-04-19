using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblConfigStaticNormales")]
    public class ConfigStaticNormales
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int AnagenAll { get; set; }
        [Required]
        public int TelogenAll { get; set; }
        [Required]
        public int AnagenTerm { get; set; }
        [Required]
        public int TelogenTerm { get; set; }
        [Required]
        public int AnagenVelus { get; set; }
        [Required]
        public int TelogenVelus { get; set; }
    }
}
