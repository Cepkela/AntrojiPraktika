using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApskaitaKar
{
    public class Kuopa
    {
        public string Pavadinimas { get; set; }
        public int Id { get; set; }
        public List<Karys> Kariai;
        public string Vadovas { get; set; }

        public Kuopa(int id, List<Karys> karia, string pavadinimas)
        {
            Pavadinimas = pavadinimas;
            Id = id;
            Kariai = karia;
        }
        public Kuopa(string vadovas)
        {
            Vadovas = vadovas;
        }
    }
}
