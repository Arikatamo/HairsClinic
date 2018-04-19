using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblReportfield")]
    public class Reportfield
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(maximumLength:100)]
        public string NameDiagnos { get; set; }
        [ForeignKey("FieldTypes")]
        public int FieldTypeId { get; set; }
        public FieldType FieldTypes { get; set; }
        [ForeignKey("FieldVariants")]
        public int FieldVariantId { get; set; }
        public FieldVariants FieldVariants { get; set; }
    }
}
