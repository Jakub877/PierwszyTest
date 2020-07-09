using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyTest
{
    public class Produkt
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }
        public string Typ { get; set; }
        public List<Parametr> Parametry { get; set; }
    }

    public class Parametr
    {
        public string Nazwa { get; set; }
        public string Wartosc { get; set; }
    }
}
