using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblResearchStatus")]
    public class ResearchStatus
    {
        [Key]
        public int Id { get; set; }
        public string StatusName { get; set; }
    }
}
