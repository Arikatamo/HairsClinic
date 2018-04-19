using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblStatusesForPatient")]
   public class StatusesForPatient
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(maximumLength:100)]
        public string Status { get; set; }

    }
}
