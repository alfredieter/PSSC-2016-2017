using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
namespace Models.Contexts.Student
{
    class GradeReportFactory
    {
        public GradeReport createGradeReport(HashSet<EnrolledSubject> gradeReport)
        {
            Contract.Requires<ArgumentNullException>(gradeReport != null, "gradeReport");

            var GradeReport = new GradeReport(gradeReport);

            return GradeReport;
        }
    }
}
