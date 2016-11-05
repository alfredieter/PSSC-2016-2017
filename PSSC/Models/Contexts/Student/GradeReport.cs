using Models.Common.Subject;
using Models.Generics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Contexts.Student
{
    //Aggregate Root
    public class GradeReport:IStudentRepository<PlainText>
    {
        private HashSet<EnrolledSubject> _gradeReport { get; set; }

        public GradeReport(HashSet<EnrolledSubject> gradeReport)
        {
            _gradeReport = gradeReport;
        }

        ViewableSituation IStudentRepository<PlainText>.GetSubjectSituation(PlainText subjectName)
        {
            ViewableSituation situation;

            situation = _gradeReport.First(d => d.Name == subjectName).Situation;

            return situation;
        }
    }
}