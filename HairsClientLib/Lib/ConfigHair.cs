using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblConfigHair")]
    public class ConfigHair
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ConfHairSize")]
        public int ConfHaitSizeId { get; set; }
        public ConfigHairSize ConfHairSize { get; set; }
        [ForeignKey("ConfStatNormal")]
        public int ConfStatNormalId { get; set; }
        public ConfigStaticNormales ConfStatNormal { get; set; }
    }
}
