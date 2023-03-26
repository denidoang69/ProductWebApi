namespace AspNetCoreWebApi.Models
{
    /// <summary>
    /// Model class for binding the Student datagrid data.
    /// </summary>
    public class LearningViewModel
    {
        public List<LearningListItemModel> LearningClasses { get; set; } = new List<LearningListItemModel>();

        /// <summary>
        /// The total data of students in the database. Will be used for pagination.
        /// </summary>
        public int TotalData { get; set; }
    }

    /// <summary>
    /// Model class for binding the student data object.
    /// </summary>
    public class LearningListItemModel
    {
        public string LearningClassId { get; set; } = string.Empty;

        public string LecturerName { get; set; } = string.Empty;

        public string Subject { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }
    }
}
