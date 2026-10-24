using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvvmdwa.Model;

namespace mvvmdwa.ViewModel
{
    public class NapójViewModel 
    {
        public string WpisanaNazwa { get; set; }
        public string WpisaneOpakowanie{ get; set; }
        public int WpisanyCukier{ get; set; }

        public ObservableCollection<Energetyk>
            ListaNapojów
        { get; set; } = new ObservableCollection<Energetyk>();

        public System.Windows.Input.ICommand DodajNapójCommand { get; }

        public NapójViewModel()
        {
            ListaNapojów.Add(new Energetyk("Redbull", "Puszka", 11));
            ListaNapojów.Add(new Energetyk("Monster", "Puszka", 14));

            DodajNapójCommand = new Command(DodajNapój);
        }

        private void DodajNapój()
        {
            ListaNapojów.Add(new Energetyk(WpisanaNazwa, WpisaneOpakowanie, WpisanyCukier));
        }

    }
}
