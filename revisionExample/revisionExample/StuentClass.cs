using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisionExample
{
    internal class StuentClass
    {
        public string studentname { get; set; }
        public int studentYear { get; set; }
        public string studentDegree { get; set; }

        public string StudentInformation()
        {
            return $"studentname: {studentname}\n studentYear: {studentYear}\n $studentdegreee: {studentDegree}";
        }
    }
}
