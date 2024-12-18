using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
    {
        public class Student
        {
            public string RecordBook { get; set; }
            public string FullName { get; set; }
            public string Department { get; set; }
            public string Specification { get; set; }
            public DateTime DateOfAdmission { get; set; }
            public string Group { get; set; }

            public Student(string recordBook, string fullName, string department,
                           string specification, DateTime dateOfAdmission, string group)
            {
                RecordBook = recordBook;
                FullName = fullName;
                Department = department;
                Specification = specification;
                DateOfAdmission = dateOfAdmission;
                Group = group;
            }
        }
}