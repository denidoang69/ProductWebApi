namespace AspNetCoreWebApi.Models
{
    /// <summary>
    /// Model class for binding the Student datagrid data.
    /// </summary>
    public class StudentViewModel
    {
        public List<StudentListItemModel> Students { get; set; } = new List<StudentListItemModel>();

        /// <summary>
        /// The total data of students in the database. Will be used for pagination.
        /// </summary>
        public int TotalData { get; set; }
    }

    /// <summary>
    /// Model class for binding the student data object.
    /// </summary>
    public class StudentListItemModel 
    {
        public string StudentId { get; set; } = string.Empty;

        public string StudentName { get; set; } = string.Empty;

        public string? Nickname { get; set; }

        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime JoinedAt { get; set; }

        public string SchoolName { get; set; } = string.Empty;
    }
}
