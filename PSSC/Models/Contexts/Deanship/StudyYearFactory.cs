using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generics;
using Models.Common.Subject;

namespace Models.Contexts.Deanship
{
    class StudyYearFactory
    {
        //se poate crea StudyYear, lasand StudyYearFactory sa adauga in lista definedSubjects
        private List<DefinableSubject> definedSubjects;


        public void addDefinableSubject(PlainText subjectName, Credits credits, Dictionary<Common.Student.Student, ViewableSituation> enrolledStudents,
            EvaluationType examType, Common.Professor.Professor professo)
        {
            definedSubjects.Add(new DefinableSubject(subjectName, credits, enrolledStudents,
             examType, professo));

        }
        public void addDefinableSubject(PlainText subjectName, Credits credits, Dictionary<Common.Student.Student, ViewableSituation> enrolledStudents,
            EvaluationType examType, Common.Professor.Professor professor, Proportion proportion)
        {
            definedSubjects.Add(new DefinableSubject(subjectName, credits, enrolledStudents,
             examType, professor, proportion));
        }
        public void addDefinableSubject(PlainText subjectName, Credits credits, EvaluationType examType,
            Common.Professor.Professor professor, Proportion proportion)
        {

            definedSubjects.Add(new DefinableSubject( subjectName,  credits,  examType,  professor,  proportion));
        }
        public StudyYear publishListOfDefinableSubject()
        {
            return new StudyYear(definedSubjects);
        }
    }
}
