using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RK_LAB1.Models
{

    public class CourseRepository
    {
        private static List<Course>
          responses = new List<Course>();
        public static IEnumerable<Course> Responses
        {
            get { return responses; }
        }
        public static void AddResponse(Course course)
        {
            responses.Add(course);
        }
    }
}

