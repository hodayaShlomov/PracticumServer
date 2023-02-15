using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Repository.Entities
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [MaxLength(9)]
        public string IdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
      
        public bool IsMale { get; set; }
        [ForeignKey("IdHMO")]
        public  int? HMOId { get; set; }
        public virtual HMO? HMO { get; set; }
        [ForeignKey("PersonId")]
        public  int? ParentId { get; set; }
        public virtual Person? Parent { get; set; }

    }
}
