using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyTest
{
    public class Koszyk
    {
        public List<ProduktWKoszyku> Produkty { get; set; }
        private DateTime DataZamowienia { get; set; }
        private object MetodaPlatnosci { get; set; }
        private KodRabatowy Rabacik { get; set; }
        private object DaneZamawiajacego { get; set; }

        public Koszyk()
        {
            Produkty = new List<ProduktWKoszyku>();
            DataZamowienia = DateTime.Now;
        }

        public void DodajProduktDoKoszyka(Produkt produkt, int ilosc)
        {
            //szukamy pierwszego produktu na liście produktów w koszyku
            //który ma takie samo Id jak produkt, który próbujemy dodać
            //jeśli nie znajdziemy, wtedy prod będzie nullem
            var produktWKoszyku = Produkty.FirstOrDefault(p => p.Produkcik.Id == produkt.Id);

            //jeśli nie znaleźliśmy produktu, to dodajemy do koszyka
            if (produktWKoszyku == null)
                Produkty.Add(new ProduktWKoszyku { Produkcik = produkt, Ilosc = ilosc });
            //jeśli znaleźliśmy, wtedy zwiększamy ilość produktu w koszyku
            else
                produktWKoszyku.Ilosc += ilosc;
        }

        public void LINQ()
        {
            Produkty.First();

            var x = Produkty.FirstOrDefault(p => p.Produkcik.Nazwa == "Majtki" 
                    && p.Produkcik.Parametry.Any(par => par.Nazwa == "Krój" && par.Wartosc == "Figi"));

            foreach(var p in Produkty)
            {
                if (p.Produkcik.Nazwa == "Majtki")
                { 
                    foreach(var par in p.Produkcik.Parametry)
                    {
                        if(par.Nazwa == "Krój" && par.Wartosc == "Figi")
                        {
                            x = p;
                            break;
                        }
                    }
                }
            }

            Produkty.LastOrDefault();
        }
    }
}
