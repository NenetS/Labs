using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    using System;

    namespace Laba7 // Убедитесь, что пространство имен совпадает с вашим проектом
    {
        public class Student
        {
            public string RecordBook { get; set; }        // Номер студенческого билета
            public string FullName { get; set; }           // ФИО студента
            public string Department { get; set; }         // Институт
            public string Specification { get; set; }      // Направление
            public DateTime DateOfAdmission { get; set; }  // Дата зачисления
            public string Group { get; set; }              // Группа

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

}
