using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Decanat:Facultate
    {
        public string numeDepartament;
        private string sefDepartament;

        List<profesorCurs> listaProfesorCurs;

        void adaugaProfesorCurs(Profesor p, Curs c)
        {
        }

        public List<profesorCurs> ListaProfesorCurs
        {
            get { return listaProfesorCurs; }
        }


        public void generareRaport(Curs c)
        {
            //genereaza raportul per disciplina
        }

        public void generareRaport()
        {
            //genereaza raportur per ansamblu
        }
    }
}
