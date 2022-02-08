using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFClassDefinitions
{
    class Course
    {
        public string CourseCode { get; set; } //vakcode
        public string CourseName { get; set; } //vaknaam
        public int SBU{ get; set; } //studiebelasting


        public Course(string coursecode, string coursename, int SBU)
        {
            this.CourseCode = coursecode;
            this.CourseName = coursename;
            this.SBU = SBU;
        }
    }
}
