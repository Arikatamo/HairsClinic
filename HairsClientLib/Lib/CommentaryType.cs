using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblCommentaryType")]
    public class CommentaryType
    {
        [Key]
        public int Id { get; set; }
        public string ToPatient { get; set; }
        public string ToAdministrator { get; set; }
        public string DoctorToPatient { get; set; }
        public string AdministratorToHimselt { get; set; }
        public string DoctorToHimSelf { get; set; }
    }
}
