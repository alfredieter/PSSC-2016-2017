using Models.Common.Subject;
using Models.Generics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Models.Contexts.Deanship
{
    //Aggregate Root
    public class StudyYear: IDeanshipRepository<DefinableSubject>
    {
        private List<DefinableSubject> _definedSubjects;
        public ReadOnlyCollection<DefinableSubject> Subjects { get { return _definedSubjects.AsReadOnly(); } }

        public StudyYear(List<DefinableSubject> definedSubjects)
        {
            _definedSubjects = definedSubjects;
        }

        public void PublishGradeReports(IReportPublisher publisher)
        {

        }
    
        //interface implementation

        public void defineSubject(DefinableSubject entity)
        {
            _definedSubjects.Add(entity);

        }

        public void eraseSubject(DefinableSubject entity)
        {
            _definedSubjects.Remove(entity);
        }


        public void enrollStudentToSubject(PlainText subjectName, Common.Student.Student student)
        {
            _definedSubjects.Find(d => d.Name == subjectName).EnrollStudent(student);
        }

        public Grade CalculateStudentAverage(PlainText subjectName, RegistrationNumber regNumber)
        {
            return _definedSubjects.Find(d => d.Name == subjectName).GetStudentAverage(regNumber);
        }

        public ViewableSituation GetStudentSituation(PlainText subjectName, RegistrationNumber regNumber)
        {
            return _definedSubjects.Find(d => d.Name == subjectName).GetStudentSituation(regNumber);
        }
        public bool checkCredits(RegistrationNumber regNumber)
        {
            int credits = 0;
            foreach (DefinableSubject df in _definedSubjects)
            {
                for (int i = 0; i < df._enrolledStudents.Count(); i++)
                {
                    if (df._enrolledStudents.ElementAt(i).Key.RegNumber == regNumber)
                        credits += df.credits.Count;
                }
            }
            if (credits == 60)
                return true;
            else return false;
        }
    }
}
