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
        public DateTime Data { get; set; }
        public string Ivertinimas { get; set; }
        public int Soviniai { get; set; }
        public _5Pratimas Pratimas { get; set; }
        public Karys(int id, string vardas, string pavarde, string laipsnis, DateTime data, string ivertinimas)
        {
            Id = id;
            Vardas = vardas;
            Pavarde = pavarde;
            Laipsnis = laipsnis;
            Data = data;
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
        public void padeciuIrasymas(int gulint, int stovint, int isApkaso, int sedint, int priklaupus)
        {
            Pratimas = new _5Pratimas(gulint, isApkaso, priklaupus, sedint, stovint);
        }

    }
}
