using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generics;

namespace Models.Contexts.Deanship
{
    public interface IDeanshipRepository<T>
    {

        void defineSubject(T entity);
        void eraseSubject(T entity);
        void enrollStudentToSubject(Models.Generics.PlainText subjectName, Common.Student.Student student);
        Grade CalculateStudentAverage(PlainText subjectName, RegistrationNumber regNumber);
        Models.Common.Subject.ViewableSituation GetStudentSituation(PlainText subjectName, RegistrationNumber regNumber);
    }
}
