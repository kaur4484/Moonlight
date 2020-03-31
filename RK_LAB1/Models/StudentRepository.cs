using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RK_LAB1.Models
{

    public class StudentRepository
    {
        private static List<User>
          responses = new List<User>();
        public static IEnumerable<User> Responses
        {
            get { return responses; }
        }
        public static void AddResponse(User student)
        {
            responses.Add(student);
        }
    }
}

 