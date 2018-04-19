using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblDiagnoses")]
    public class Diagnoses
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(maximumLength:2000)]
        public string Diagnos { get; set; }
        [Required]
        public DateTime BeginDate { get; set; }
        [Required]
        public DateTime DateOfLastConfirm { get; set; }
        [Required, StringLength(maximumLength: 1000)]
        public string Commentary { get; set; }
    }
}
