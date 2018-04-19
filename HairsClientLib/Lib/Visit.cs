using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblVisit")]
    public class Visit
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        public IList<User> Users { get; set; }
        [ForeignKey("Patients")]
        public int PatientId { get; set; }
        public Patient Patients { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [ForeignKey("Commentary")]
        public int CommentaryId { get; set; }
        public IList<CommentaryToVisit> Commentary { get; set; }
        [ForeignKey("Reserches")]
        public int ResearchId { get; set; }
        public IList<Research> Reserches { get; set; }
    }
}
