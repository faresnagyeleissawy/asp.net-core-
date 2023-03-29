namespace EVC_DAY2.Models;
public class Department
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public string Mananger { get; set; }
    public virtual ICollection<Instructor> instructors { get; set; } = new List<Instructor>();
    public virtual ICollection<Course> Courses{ get; set; } = new List<Course>();
    public virtual ICollection<Trainee> Trainees{ get; set; } = new List<Trainee>();



}

