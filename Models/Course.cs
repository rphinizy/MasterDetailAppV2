using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FrisbeeGolfCourseMap.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Location { get; set; }
        public string Difficulty { get; set; }
        public int NumberOfHoles { get; set; }
        public int TimeToComplete { get; set; }
        public int ThrowTotal { get; set; }
        public string Description { get; set; }

    }
}
