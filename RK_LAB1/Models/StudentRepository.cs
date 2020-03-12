using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RK_LAB1.Models
{

    public class StudentRepository
    {
        private static List<Student>
          responses = new List<Student>();
        public static IEnumerable<Student> Responses
        {
            get { return responses; }
        }
        public static void AddResponse(Student student)
        {
            responses.Add(student);
        }
    }
}

 