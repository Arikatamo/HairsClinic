using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblObjectives")]
    public class Objectives
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(maximumLength:50)]
        public string NameObjectiv { get; set; }
        [Required]
        public string Scale { get; set; }
    }
}
