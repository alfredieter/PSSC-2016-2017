using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student
    {
        public List<Curs> orar;
        public string numeStudent;
        public void adaugaCursNou(Curs c)
        {
            orar.Add(c);
        }
    }

}
