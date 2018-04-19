using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Lib
{
    [Table("tblContscts")]
   public class ContactS
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(maximumLength:100)]
        public string Name { get; set; }
        [Required, StringLength(maximumLength: 100)]
        public string SecondName { get; set; }
        [Required, StringLength(maximumLength: 100)]
        public string FatherName { get; set; }
        [ForeignKey("Gender")]
        public int GenderSId { get; set; }
        public GenderS Gender { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required, StringLength(maximumLength: 50)]
        public string  Phone { get; set; }
        [Required, StringLength(maximumLength: 100)]
        public string Email { get; set; }
        [Required, StringLength(maximumLength: 300)]
        public string Adress { get; set; }
        [Required, StringLength(maximumLength: 100)]

        public string Post { get; set; }
        [Required, StringLength(maximumLength: 100)]
        public string Speciality { get; set; }
        [Required, StringLength(maximumLength: 100)]
        public string Education { get; set; }
        [Required, StringLength(maximumLength: 1000)]
        public string Commentary { get; set; }
        [Required, StringLength(maximumLength: 100)]
        public string Grade { get; set; }

    }
}
