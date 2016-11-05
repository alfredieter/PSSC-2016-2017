using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    public class Grade
    {
        private decimal _value;
        public decimal Value { get { return _value; } }

        public Grade(decimal value)
        {
            if (value > 10 || value < 0)
                throw new System.ArgumentException("Nota invalida", "value");
            else
                _value = value;
        }
    }
}
