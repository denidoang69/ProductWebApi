using AspNetCoreWebApi.Models;
using AspNetCoreWebApi.Sql.Entities;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AspNetCoreWebApi.Services
{
    public class LearningClassService
    {
        private readonly TurboBootcampDbContext _db;

        public LearningClassService(TurboBootcampDbContext db)
        {
            _db = db;
        }

        /// <param name="lecturerName"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public async Task<LearningViewModel> GetLearning(string? lecturerName, int page)
        {
            var query = from lc in _db.Lecturers
                        join cl in _db.Classes on lc.LecturerId equals cl.LecturerId
                        select new { lc, cl };

            if (!string.IsNullOrEmpty(lecturerName))
            {
                var lecturerNameText = lecturerName.ToUpper();
                query = query.Where(Q => Q.lc.LecturerName.ToUpper().StartsWith(lecturerNameText));
            }

            var totalData = await query.CountAsync();

            var itemPerPage = 5;

            if (page >= 1)
            {
                page -= 1;
            }

            query = query
               // Don't forget to include ORDER BY clause whenever you want to implement an offset pagination.
               .OrderBy(Q => Q.cl.StartDate)
               // Skip based on page X itemPerPage, example: 1 page X 3 itemPerPage, so you will skip 3 items and retrieve the next 3 items on the next page.
               .Skip(page * itemPerPage)
               // Take the whole items on the next page, example: 3 itemPerPage, then users will retrieve 3 itemPerPage
               .Take(itemPerPage);

            var Learning = await query
                .AsNoTracking()
                .Select(Q => new LearningListItemModel
                {
                    LearningClassId = Q.cl.LearningClassId,
                    LecturerName = Q.lc.LecturerName,
                    Subject = Q.lc.Subject,
                    StartDate = Q.cl.StartDate,
                    FinishDate = Q.cl.FinishDate
                })
                .ToListAsync();

            return new LearningViewModel
            {
                LearningClasses = Learning,
                TotalData = totalData
            };
        }
    }
}
