using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreWebApi.Sql.Entities
{
    public partial class LearningClass
    {
        public string LearningClassId { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int? LecturerId { get; set; }
        public virtual Lecturer? Lecturer { get; set; }
    }
}
