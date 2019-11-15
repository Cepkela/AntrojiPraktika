using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApskaitaKar
{
    public class Vadovas
    {
        public int Id { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string Laipsnis { get; set; }

        public Vadovas(int id, string vardas, string pavarde, string laipsnis)
        {
            Id = id;
            Vardas = vardas;
            Pavarde = pavarde;
            Laipsnis = laipsnis;
        }
        public void printVadovas()
        {
            MessageBox.Show("Jusu kuopos saudymus ves: " + this.Vardas + " " + this.Pavarde + " " +
                this.Laipsnis);
        }
    }
}
