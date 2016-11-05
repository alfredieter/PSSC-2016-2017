using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    public class Attendance
    {
        private int _count;
        public int Count { get; internal set; }

        public Attendance(int count)
        {
            if (count > 14 || count < 0)
                throw new System.ArgumentException("Prezenta invalida", "count");
            else
                _count = count;
        }
    }
}
