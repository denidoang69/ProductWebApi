﻿using System;
using System.Collections.Generic;

namespace AspNetCoreWebApi.Sql.Entities
{
    public partial class School
    {
        public School()
        {
            Students = new HashSet<Student>();
            Lecturers = new HashSet<Lecturer>();
        }

        public int SchoolId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime EstablishedAt { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Lecturer> Lecturers { get; set; }
    }
}
