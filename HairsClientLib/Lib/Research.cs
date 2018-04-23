using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblResearch")]
   public class Research
    {
        [Key]
        public int  Id { get; set; }
        [ForeignKey("ResearchType")]
        public int ResearchTypeId { get; set; }
        public ResearchType ResearchType { get; set; }
        [ForeignKey("ResearchStatuses")]
        public int ResearchStatusId { get; set; }
        public ResearchStatus ResearchStatuses { get; set; }
        [Required]
        public byte[] Thunmbnail { get; set; }
        [ForeignKey("Photo")]
        public int PhotosId { get; set; }
        public Photoses Photo { get; set; }
        [ForeignKey("Hairs")]
        public int HairsId { get; set; }
        public Hair Hairs { get; set; }
        [Required]
        public int ResearchArea { get; set; }
        [Required,StringLength(maximumLength:2000)]
        public string Commentary { get; set; }
        [Required]
        public DateTime TimeResearch { get; set; }
        [ForeignKey("Diagnos")]
        public int DiagnosId { get; set; }
        public Diagnoses Diagnos { get; set; }
        [Required]
        public string Treatment { get; set; }
        [ForeignKey("Config")]
        public int ConfigId { get; set; }
        public Diagnoses Config { get; set; }
        [ForeignKey("Lens")]
        public int ObjectiveId { get; set; }
        public Objectives Lens { get; set; }
        [ForeignKey("Reports")]
        public int ReportTemplateId { get; set; }
        public IList<ReportTemplate> Reports { get; set; }


    }
}
