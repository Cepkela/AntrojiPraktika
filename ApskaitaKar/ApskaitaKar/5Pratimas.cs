using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApskaitaKar
{
    public class _5Pratimas
    {
        string pavadinimas = "5Pratimas";
        public int Gulint { get; set; }
        public int IsApkaso { get; set; }
        public int Priklaupus { get; set; }
        public int Sedint { get; set; }
        public int Stovint { get; set; }
        public _5Pratimas(int gulint, int isApkaso, int priklaupus, int sedint, int stovint)
        {
            Gulint = gulint;
            IsApkaso = isApkaso;
            Priklaupus = priklaupus;
            Sedint = sedint;
            Stovint = stovint;
        }
    }
}
