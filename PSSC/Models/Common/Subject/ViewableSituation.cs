using Models.Generics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common.Subject
{
    public class ViewableSituation : SubjectSituation
    {
        public Attendance Attendance { get { return Attendance; } private set { Attendance = value; } }
        public List<Grade> ExamGrades { get { return ExamGrades; } private set { ExamGrades = value; } }
        public List<Grade> ActivityGrades { get { return ActivityGrades; } private set { ActivityGrades = value; } }

        public ViewableSituation(Attendance att, List<Grade> examGrades, List<Grade> activityGrades) 
            : base(att, examGrades, activityGrades)
        {
            Attendance = att;
            ExamGrades = examGrades;
            ActivityGrades = activityGrades;

        }
    }
}
