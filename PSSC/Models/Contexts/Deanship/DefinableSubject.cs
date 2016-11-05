using Models.Common.Subject;
using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Contexts.Deanship
{
    public class DefinableSubject : Subject
    {
        public Common.Professor.Professor Professor { get; internal set; }
        public EvaluationType ExamType { get; internal set; }
        public Proportion Proportion { get; internal set; }

        public PlainText subjectName { get; internal set; }
        public Credits credits { get; internal set; }

        public Dictionary<Common.Student.Student, ViewableSituation> _enrolledStudents { get; set; }
        
        public DefinableSubject(PlainText subjectName, Credits credits, Dictionary<Common.Student.Student, ViewableSituation> enrolledStudents,
            EvaluationType examType, Common.Professor.Professor professor) : base(subjectName, credits)
        {
            this.subjectName = subjectName;
            this.credits = credits;

            ExamType = examType;
            Professor = professor;

            _enrolledStudents = enrolledStudents;
        }

        public DefinableSubject(PlainText subjectName, Credits credits, Dictionary<Common.Student.Student, ViewableSituation> enrolledStudents,
            EvaluationType examType, Common.Professor.Professor professor, Proportion proportion) : base(subjectName, credits)
        {
            this.subjectName = subjectName;
            this.credits = credits;

            ExamType = examType;
            Professor = professor;
            Proportion = proportion;

            _enrolledStudents = enrolledStudents;
        }

        public DefinableSubject(PlainText subjectName, Credits credits, EvaluationType examType, 
            Common.Professor.Professor professor, Proportion proportion) : base(subjectName, credits)
        {
            this.subjectName = subjectName;
            this.credits = credits;

            ExamType = examType;
            Professor = professor;
            Proportion = proportion;

            _enrolledStudents = new Dictionary<Common.Student.Student, ViewableSituation>();
        }

        public void EnrollStudent(Common.Student.Student student)
        {
            List<Grade> examGrades = new List<Grade>();
            List<Grade> activityGrade = new List<Grade>();
            _enrolledStudents.Add(student, new ViewableSituation(new Attendance(0), examGrades, activityGrade ));
        }

        public Grade GetStudentAverage(RegistrationNumber regNumber)
        {
            return _enrolledStudents.First(d => d.Key.RegNumber == regNumber).Value.GetExamAverage();
        }

        public void ChangeProfessor(Common.Professor.Professor professor)
        {
            Professor = professor;
        }

        public ViewableSituation GetStudentSituation(RegistrationNumber regNumber)
        {
            return _enrolledStudents.First(d => d.Key.RegNumber == regNumber).Value;
        }

    }
}
