using System.ComponentModel.DataAnnotations.Schema;

namespace EVC_DAY2.Models
{
    public class CrsResult
    {
        public int Id { get; set; }
        public int Degree { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        [ForeignKey("Trainee")]
        public int TraineeId { get; set; }

        public virtual Trainee Trainee { get; set; }
        public virtual Course Courses { get; set; } 

    }
}
