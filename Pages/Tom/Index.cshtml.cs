using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FrisbeeGolfCourseMap.Data;
using FrisbeeGolfCourseMap.Models;

namespace FrisbeeGolfCourseMap.Pages.Tom
{
    public class IndexModel : PageModel
    {
        private readonly FrisbeeGolfCourseMap.Data.FrisbeeGolfCourseMapContext _context;

        public IndexModel(FrisbeeGolfCourseMap.Data.FrisbeeGolfCourseMapContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Course.ToListAsync();
        }
    }
}
