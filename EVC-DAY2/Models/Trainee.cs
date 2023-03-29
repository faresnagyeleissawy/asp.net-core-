using System.ComponentModel.DataAnnotations.Schema;

namespace EVC_DAY2.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; } = "";
        public char Grade { get; set; }
        public string Address { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
     
        public virtual Department? Department { get; set; }
        public virtual ICollection<CrsResult> CrsResult { get; set; } = new HashSet<CrsResult>();

    }
}
