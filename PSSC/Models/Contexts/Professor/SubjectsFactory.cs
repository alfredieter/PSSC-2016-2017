using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Models.Contexts.Professor
{
    class SubjectsFactory
    {
        //verifica lista sa nu fie nula
        public Subjects createSubject(List<TeachingSubject> subjects)
        {
            Contract.Requires(subjects != null, "subjects");

            return new Subjects(subjects);
        }
    }
}
