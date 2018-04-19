using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblConfigHairSize")]
    public   class ConfigHairSize
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public short TelogenHairLong { get; set; }
        [Required]
        public short Diametr_Velus_Terminale { get; set; }
        [Required]
        public short Diametr_Terminale_S_M { get; set; }
        [Required]
        public short Diametr_Terminale_M_B { get; set; }
        [Required]
        public short Radius_Folikular_Unit { get; set; }

    }
}
