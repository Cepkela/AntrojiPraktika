using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApskaitaKar
{
    public class Karys
    {
        public int Id { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string Laipsnis { get; set; }
        public int Taskai { get; set; }
        public string Ivertinimas { get; set; }
        public int Soviniai { get; set; }
        public Karys(int id, string vardas, string pavarde, string laipsnis, int taskai, string ivertinimas)
        {
            Id = id;
            Vardas = vardas;
            Pavarde = pavarde;
            Laipsnis = laipsnis;
            Taskai = taskai;
            Ivertinimas = ivertinimas;
        }
        public Karys(int soviniai)
        {
            Soviniai = soviniai;
        }
        public int soviniuPaskirstymas(int kartojimuKiekis)
        {
            int rezultatas = 30 * kartojimuKiekis;
            return rezultatas;
        }

    }
}
