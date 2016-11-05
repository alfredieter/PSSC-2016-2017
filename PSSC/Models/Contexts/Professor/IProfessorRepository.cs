using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generics;

namespace Models.Contexts.Professor
{
    public interface IProfessorRepository
    {
        void AddExamGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade);

        void AddActivityGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade);

        void AddAttendance(PlainText subjectName, RegistrationNumber regNumber, Attendance attendance);

        void SetActivityProportion(PlainText subjectName, Proportion proportion);
    }
}
