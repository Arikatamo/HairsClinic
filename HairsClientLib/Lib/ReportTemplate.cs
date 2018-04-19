using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblReportTemplate")]
    public class ReportTemplate
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Images")]
        public int ImgID { get; set; }
        public IList<ImageLogo> Images { get; set; }
        [ForeignKey("FieldTypes")]
        public int FieldTypeId { get; set; }
        public IList<FieldType> FieldTypes { get; set; }
        [ForeignKey("ReportFields")]
        public int ReportFieldId { get; set; }
        public IList<Reportfield> ReportFields { get; set; }
    }
}
