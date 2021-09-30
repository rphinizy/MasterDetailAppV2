using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FrisbeeGolfCourseMap.Data;
using FrisbeeGolfCourseMap.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FrisbeeGolfCourseMap.Pages.Tom
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
        //public SelectList Difficulty { get; set; }
        //[BindProperty(SupportsGet = true)]
        //public string CourseDifficulty { get; set; }
        public string NameSort { get; set; }
        public async Task OnGetAsync(string sortOrder)
        {
            NameSort = sortOrder;

            var course = from c in _context.Course
                         select c;

            if (!string.IsNullOrEmpty(SearchString))
            {
                course = course.Where(c => c.Name.Contains(SearchString));
            }
            // if(!string.IsNullOrEmpty(CourseDifficulty))
            // {
            //     course = course.Where(d => d.Difficulty == (CourseDifficulty));
            //}
            //Difficulty = new SelectList(await difficultyQuery.Distinct().ToListAsync());


            if (NameSort == "desc")
            {
                course = course.OrderByDescending(c => c.Name);
            }
            else
            {
                course = course.OrderBy(c => c.Name);
            }

            Course = await course.ToListAsync();
        }
    }
}
