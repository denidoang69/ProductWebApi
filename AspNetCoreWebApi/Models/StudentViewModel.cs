namespace AspNetCoreWebApi.Models
{
    /// <summary>
    /// Model class for binding the student data object.
    /// </summary>
    public class StudentViewModel
    {
        public string StudentId { get; set; } = string.Empty;

        public string StudentName { get; set; } = string.Empty;

        public string? Nickname { get; set; }

        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime JoinedAt { get; set; }

        public string SchoolName { get; set; } = string.Empty;
    }
}
