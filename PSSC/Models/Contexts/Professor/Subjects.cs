using Models.Generics;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Common.Subject;

namespace Models.Contexts.Professor
{
    //Aggregate Root
    public class Subjects: IProfessorRepository
    {
        private List<TeachingSubject> _subjects { get; set; }
        public ReadOnlyCollection<TeachingSubject> AllSubjects { get { return _subjects.AsReadOnly(); } }

        public Subjects(List<TeachingSubject> subjects)
        {
            
            _subjects = subjects;
        }

        void IProfessorRepository.AddExamGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            _subjects.Find(d => d.Name == subjectName).AddExamGrade(regNumber, grade);
        }

        void IProfessorRepository.AddActivityGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            _subjects.Find(d => d.Name == subjectName).AddActivityGrade(regNumber, grade);
        }

        void IProfessorRepository.AddAttendance(PlainText subjectName, RegistrationNumber regNumber, Attendance attendance)
        {
            _subjects.Find(d => d.Name == subjectName).AddAttendance(regNumber, attendance);
        }

        void IProfessorRepository.SetActivityProportion(PlainText subjectName, Proportion proportion)
        {
            _subjects.Find(d => d.Name == subjectName).SetActivityProportion(proportion);
        }
    }
}
