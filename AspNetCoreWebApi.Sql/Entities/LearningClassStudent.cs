using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreWebApi.Sql.Entities
{
    public partial class LearningClassStudent
    {
        [Key]
        public string LearningClassId { get; set; } = null!;
        public string StudentId { get; set; } = null!;
    }
}
