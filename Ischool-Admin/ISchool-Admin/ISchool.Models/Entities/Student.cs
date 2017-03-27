using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISchool.Models.Entities
{
    public class Student : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }

        [ForeignKey("Group")]
        public int GroupId { get; set; }

        public virtual Person Person { get; set; }
        public virtual Group Group { get; set; }        
    }
}
