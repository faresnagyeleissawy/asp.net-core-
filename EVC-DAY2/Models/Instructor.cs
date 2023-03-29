﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace EVC_DAY2.Models;

public class Instructor
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string Image { get; set; } = "";
    public float Salary { get; set; }
    public string Address { get; set; }

    [ForeignKey("Department")]
    public int DepartmentId { get; set; }
    [ForeignKey("Course")]
    public int CourseId { get; set; }

    public virtual Department? Department { get; set; }
    public virtual Course? Course { get; set; }




}

