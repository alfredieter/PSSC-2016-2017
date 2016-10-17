using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Catalog
    {
        Student s;
        Nota n;
        public Catalog(Student s, Nota n)
        {
            this.s = s;
            this.n = n;
        }
    }
}
