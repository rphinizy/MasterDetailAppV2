using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FrisbeeGolfCourseMap.Data;
using System;
using System.Linq;

namespace FrisbeeGolfCourseMap.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FrisbeeGolfCourseMapContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FrisbeeGolfCourseMapContext>>()))
            {
                // Look for any course.
                if (context.Course.Any())
                {
                    return;   // DB has been seeded
                }

                context.Course.AddRange(
                    new Course
                    {
                        Name = "Green Lake Disc Golf Park",
                        Alias = "",
                        Location = "9230 Youker Rd, Interlochen, MI 49643",
                        Difficulty = "Very Hard",
                        NumberOfHoles = 18,
                        TimeToComplete = 3,
                        ThrowTotal = 60,
                        Description = "The Green Lake DiscGolfPark, designed by 2009 Disc Golf World Champion, Avery Jenkins, is the 1st DiscGolfPark established in Michigan and the 30th DiscGolfPark installed in the US."
                    },

                    new Course
                    {
                        Name = "Kingsley Civic Center South",
                        Alias = "OG",
                        Location = "Clark St Kingsley, MI 49649",
                        Difficulty = "Intermediate",
                        NumberOfHoles = 18,
                        TimeToComplete = 2,
                        ThrowTotal = 54,
                        Description = "In a 40 acre park.First 7 holes are open.Wind and elevation in play.Remaining holes are wooded with elevation.Gate locked at 8pm - park outside and begin at hole six."
                    },

                    new Course
                    {
                        Name = "The Backyard",
                        Alias = "Carly’s Playground / Terrace Park",
                        Location = "661 Amy Ave, Traverse City, MI 49686",
                        Difficulty = "Easy",
                        NumberOfHoles = 24,
                        TimeToComplete = 3,
                        ThrowTotal = 72,
                        Description = "Pet and family friendly course.Wooded courses, lots of trees and tricky shots.Established in 2012 as a memorial course for the owners daughter Carly.Located near Traverse City High school and NMC.Suggested donation is $2 per day."
                    },

                    new Course
                    {
                        Name = "Crystal Mountain",
                        Alias = "",
                        Location = "12500 Crystal Mountain Dr., Thompsonville, MI 49683",
                        Difficulty = "Medium",
                        NumberOfHoles = 9,
                        TimeToComplete = 2,
                        ThrowTotal = 35,
                        Description = "The course(redesigned in 2016) begins at the top of Loki.Disc golf rental($12) includes chairlift ride to the top during Alpine Slide Loki Lift hours(see below). $5 fee for a chairlift pass without disc rental.The course is also accessible via a marked path up the mountain.Opens on Memorial Day weekend! Discs available for rent at Mountain Adventure Zone June 11 - Sept. 5.Please visit the Park at Water's Edge after Sept. 6 to rent discs. Available through October 31. Open during non-ski season. 2016 SUMMER SEASON LIFT HOURS= June 11 - Sept. 5 11am-8pm 2016 FALL SEASON LIFT HOURS= Check with Crystal Mountain - (800) 968-7686 x 7000"
                    },
                    new Course
                    {
                        Name = "Log Lake Park",
                        Alias = "",
                        Location = "2339 E Log Lake Rd, Kalkaska, MI 49646",
                        Difficulty = "Hard",
                        NumberOfHoles = 18,
                        TimeToComplete = 2,
                        ThrowTotal = 54,
                        Description = "Technical - lots of trees on fun, challenging holes.Onsite camping, swimming and other sports facilities."

                    },
                    new Course
                    {
                        Name = "Avalanche Preserve Recreation Area",
                        Alias = "",
                        Location = "1129 Wilson St, Boyne City, MI 49712",
                        Difficulty = "Hard",
                        NumberOfHoles = 18,
                        TimeToComplete = 3,
                        ThrowTotal = 58,
                        Description = "A good hike through a mixed northern forest.The course begins in some lower meadows and then climbs to the top of Avalanche Mountain.Unmatched view on #18. Long walks between some holes. Mixed use trails and park."

                    },
                    new Course {
                        Name = "Northwestern Michigan College",
                        Alias = "",
                        Location = "Dogwood Parking Lot, College Dr, Traverse City, MI 49686",
                        Difficulty = "Beginner",
                        NumberOfHoles = 9,
                        TimeToComplete = 1,
                        ThrowTotal = 27,
                        Description = "New pin placements and fresh chains for 2020.Fun and short game course.Located on campus with a mix of trees and mild elevation changes.Student traffic may cause delays during playthrough."
                    },
                    new Course
                    {
                        Name = "Central Michigan University",
                        Alias = "CMU Disc Golf Course",
                        Location = "2525 University Park Dr Mount Pleasant, MI 48858",
                        Difficulty = "Beginner",
                        NumberOfHoles = 18,
                        TimeToComplete = 1,
                        ThrowTotal = 58,
                        Description = "Open to the public. New tee pads, hole signs, and numberings as of August 2021."
                    },
                    new Course
                    {
                        Name = "Flip City",
                        Alias ="",
                        Location = "1120 E Pierce Rd Shelby, MI 49455",
                        Difficulty = "Very Hard",
                        NumberOfHoles = 24,
                        TimeToComplete = 3,
                        ThrowTotal = 75,
                        Description = "Very hilly and lightly wooded.One of the top rated disc golf courses in Michigan for its uniquely challenging shots and beautiful scenery.Established and designed in 1980 by Bill McKenzie.Private course $5.00 to play all day."
                    },
                    new Course
                    {
                        Name = "TC High School",
                        Alias ="",
                        Location = "3962 N Three Mile Rd Traverse City, MI 49686",
                        Difficulty = "Very Easy",
                        NumberOfHoles = 6,
                        TimeToComplete = 1,
                        ThrowTotal = 18,
                        Description = "Perfect for beginners.Very basic 6 hole course.It’s never crowded.Don’t expect regular upkeep of the course."
                    }
                ) ;
                context.SaveChanges();
            }
        }
    }
}