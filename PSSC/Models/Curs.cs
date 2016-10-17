using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum tipEvaluare { distribuita, normala };
    enum proportieActivitateParcurs { jumatate, treime };
    class Curs
    {
        private string numeCurs, sala;
        List<Student> listaStudenti;
        List<Catalog> listaCatalog;
        tipEvaluare tip;
        proportieActivitateParcurs proportie;

        public Curs(List<Student> s)
        {
            listaStudenti = s;
        }

        public int medieStudent(Student s)
        {
            //cauta in catalog studentul si ia Nota
        }

        public void addNota(Student s, Nota n)
        {
            Catalog c = new Catalog(s, n);
            listaCatalog.Add(c);
        }

        public string NumeCurs
        {
            get { return numeCurs; }
        }

        public List<Student> ListaStudenti
        {
            get { return listaStudenti; }
        }

        public List<Catalog> ListaCatalog
        {
            get { return listaCatalog;}
        }
    }
}
