using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmdwa.Model
{
    public abstract class Napój
    {
        public string Nazwa { get; set; }
        public string Opakowanie { get; set; }

        public Napój(string nazwa, string opakowanie)
        {
            Nazwa = nazwa;
            Opakowanie = opakowanie;
        }
    }

    public class Energetyk : Napój
    {
        public int IleCukru { get; set; }

        public Energetyk(string nazwa, string opakowanie, int ileCukru) 
            : base(nazwa, opakowanie)
        {
            IleCukru = ileCukru;
        }

    }
}
