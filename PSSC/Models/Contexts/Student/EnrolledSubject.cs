﻿using Models.Common.Subject;
using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Contexts.Student
{
    public class EnrolledSubject : Subject
    {
        public Common.Professor.Professor Professor { get; set; }
        public ViewableSituation Situation { get; set; }

        public EnrolledSubject(ViewableSituation situation, Common.Professor.Professor professor, PlainText subjectName, Credits credits)
            : base(subjectName, credits)
        {
            Situation = situation;
            Professor = professor;
        }
    }
}
