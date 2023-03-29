﻿using System.ComponentModel.DataAnnotations.Schema;

namespace EVC_DAY2.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public virtual ICollection<CrsResult> CrsResult { get; set; } = new HashSet<CrsResult>();
    }
}
