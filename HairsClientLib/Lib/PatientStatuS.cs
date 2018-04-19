using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblPatientStatus")]
    public class PatientStatuS
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Status")]
        public int StatusID { get; set; }
        public StatusesForPatient Status { get; set; }
    }
}
