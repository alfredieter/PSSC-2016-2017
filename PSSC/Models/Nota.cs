using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Nota
    {
        List<int> notaExamen1, notaLaborator, notaExamen2;
        int prezenteLaborator;

        public void adaugaNotaExamen1(int nota)
        {
            notaExamen1.Add(nota);
        }

        public void adaugaNotaExamen2(int nota)
        {
            notaExamen2.Add(nota);
        }

        public void adaugaNotaLaborator(int nota)
        {
            notaLaborator.Add(nota);
        }

        public int PrezenteLaborator
        {
            get { return prezenteLaborator; }
            set { prezenteLaborator = value; }
        }
    }
}
