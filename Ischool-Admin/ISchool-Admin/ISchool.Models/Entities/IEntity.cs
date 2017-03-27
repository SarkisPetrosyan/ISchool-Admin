using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISchool.Models.Entities
{
    public interface IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int Id { get; set; }
        DateTime CreatedDt { get; set; }
        int CreatedBy { get; set; }
        DateTime UpdatedDt { get; set; }
        int UpdatedBy { get; set; }
        bool IsDeleted { get; set; }
    }
}
