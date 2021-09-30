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

namespace FrisbeeGolfCourseMap.Pages.Neal
{
    public class IndexModel : PageModel
    {
        private readonly FrisbeeGolfCourseMap.Data.FrisbeeGolfCourseMapContext _context;

        public IndexModel(FrisbeeGolfCourseMap.Data.FrisbeeGolfCourseMapContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public string NameSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            NameSort = sortOrder;

            var courses = from c in _context.Course
                          select c;

            if (!string.IsNullOrEmpty(SearchString))
            {
                courses = courses.Where(c => c.Name.Contains(SearchString));
            }

            if (NameSort == "desc")
            {
                courses = courses.OrderByDescending(c => c.Name);
            }
            else
            {
                courses = courses.OrderBy(c => c.Name);
            }

            Course = await courses.ToListAsync();
        }
    }
}
