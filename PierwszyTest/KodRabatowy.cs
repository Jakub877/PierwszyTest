using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyTest
{
    public class KodRabatowy
    {
        public string Kod { get; set; }
        public decimal ZnizkaKwotowa { get; set; }
        public DateTime DataWaznosci { get; set; }
        public bool CzyWykorzystany { get; set; }
    }
}
