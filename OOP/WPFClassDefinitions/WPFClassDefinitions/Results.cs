using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFClassDefinitions
{
    class Results
    {
        public string CourseName { get; set; } //vaknaam
        public int CourseResults { get; set; } //studiebelasting


        public Results(string coursename, int result)
        {
            this.CourseName = coursename;
            this.CourseResults = result;
        }
    }
}
