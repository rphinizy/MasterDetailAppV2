using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FrisbeeGolfCourseMap.Data;
using FrisbeeGolfCourseMap.Models;

namespace FrisbeeGolfCourseMap.Pages.Robin
{
    public class IndexModel : PageModel
    {
        private readonly FrisbeeGolfCourseMap.Data.FrisbeeGolfCourseMapContext _context;

        public IndexModel(FrisbeeGolfCourseMap.Data.FrisbeeGolfCourseMapContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Times { get; set; }
        //[BindProperty(SupportsGet = true)]
        //public int CourseTime { get; set; }
        public string TimeSort { get; set; }
        public string NameSort { get; set; }


        public async Task OnGetAsync(string sortOrder)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "NameDesc" : "";
            TimeSort = sortOrder == "TimeAsc" ? "TimeDesc" : "TimeAsc";

            var courses = from c in _context.Course
                          select c;

            if (!string.IsNullOrEmpty(SearchString))
            {
                courses = courses.Where(s => s.Name.Contains(SearchString));
            }

            switch (sortOrder)
            {
                case "NameDesc":
                    courses = courses.OrderByDescending(c => c.Name);
                    break;
                case "TimeDesc":
                    courses = courses.OrderByDescending(c => c.TimeToComplete);
                    break;
                case "TimeAsc":
                    courses = courses.OrderBy(c => c.TimeToComplete);
                    break;
                default:
                    courses = courses.OrderBy(c => c.Name);
                    break;
            }

            Course = await courses.ToListAsync();

        }
    }
}
