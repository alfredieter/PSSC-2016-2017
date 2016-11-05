using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    public class PlainText
    {
        private string _text;
        public string Text { get { return _text; } }

        public PlainText(string text)
        {
            if (text.Length > 50 || text.Length < 3)
                throw new System.ArgumentException("Nume invalid", "text");
            else
                 _text = text;
        }
    }
}
