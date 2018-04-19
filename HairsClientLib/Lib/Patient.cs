using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblPatient")]
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Contact")]
        public int ContactId { get; set; }
        public ContactS Contact { get; set; }
        [ForeignKey("Status")]
        public int StatusId { get; set; }
        public StatusesForPatient Status { get; set; }
        [Required]
        public DateTime DateCreate { get; set; }
        [Required,StringLength(maximumLength:2000)]
        public string Comment { get; set; }
        [ForeignKey("Photos")]
        public int PhotosId { get; set; }
        public IList<Photoses> Photos { get; set; }
        [Required]
        public DateTime DateNextVisit { get; set; }
        [Required]
        public DateTime TimeNextVisit { get; set; }
    }
}
