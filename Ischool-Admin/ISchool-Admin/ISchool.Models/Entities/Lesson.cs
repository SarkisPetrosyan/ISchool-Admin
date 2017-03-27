using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISchool.Models.Entities
{
    public class Lesson : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        [ForeignKey("Group")]
        public int GroupId { get; set; }

        public DateTime LessonDate { get; set; }
        public int StudentsCount { get; set; }
        public string LessonSubject { get; set; }


        public virtual Teacher Teacher { get; set; }
        public virtual Group Group { get; set; }
    }
}
