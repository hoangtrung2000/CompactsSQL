using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.StudentManagement
{
    class StudentView
    {
        public int id {get;set;}
        public string Code {get; set; }
        public string Name {get; set; }
        public DateTime Birthday { get; set; }
        public string Class { get; set; }

        public StudentView(Student student)
        {
            this.id = student.id;
            this.Code = student.Code;
            this.Name = student.Name;
            this.Birthday = student.Birthday;
            this.Class = student.Class.Name;
        }

    }
}
