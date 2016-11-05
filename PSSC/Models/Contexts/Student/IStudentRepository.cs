using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Contexts.Student
{
    public interface IStudentRepository<T>
    {
        Models.Common.Subject.ViewableSituation GetSubjectSituation(T subjectName);
    }
}
