using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblUser")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(maximumLength:50)]
        public string Login { get; set; }
        [Required, MaxLength(256)]
        public byte[] Password { get; set; }
        [ForeignKey("Linse")]
        public int LinseId { get; set; }
        public Objectives Linse { get; set; }
        [ForeignKey("ResearchsUser")]
        public int ResearchId { get; set; }
        public IList<Research> ResearchsUser { get; set; }
        [ForeignKey("Config")]
        public int ConfigsId { get; set; }
        public Diagnoses Config { get; set; }
        [ForeignKey("Contact")]
        public int ContactId { get; set; }
        public ContactS Contact { get; set; }
        [ForeignKey("Access")]
        public int AccesRightId { get; set; }
        public AccesRight Access { get; set; }
        [ForeignKey("Repors")]
        public int ReporsId { get; set; }
        public IList <ReportTemplate> Repors { get; set; }
    }
}
