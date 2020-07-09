using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PierwszyTest.Test
{
    [TestClass]
    public class KoszykTestUsun
    {
        private Narzedzia logika;

        public KoszykTestUsun()
        {
            logika = new Narzedzia();
        }

        [TestMethod]
        public void CzyPustyKoszyk_Jeżeli_UsuniemyGornyProduktZKoszykaZJednymProduktem()
        {
            //Arrange
            logika.UtworzKoszyk();
            logika.StworzProdukt();

            //Act
            logika.DodajPierwszyProduktDoKoszyka();
            logika.UsunGornyProduktZKoszyka();

            //Assert
            logika.SprawdzCzyPustyKoszyk_Jeżeli_UsuniemyProduktZKoszykaZJednymProduktem();
        }


        public class Narzedzia
        {
            private Koszyk koszyk;
            private Produkt produkt;
            private Produkt produkt2;

            public void UtworzKoszyk()
            {
                koszyk = new Koszyk();
            }

            public void StworzProdukt()
            {
                produkt = new Produkt();
                produkt.Id = 1;
            }

            public void StworzDrugiProdukt()
            {
                produkt2 = new Produkt();
                produkt2.Id = 2;
            }

            public void DodajPierwszyProduktDoKoszyka()
            {
                koszyk.DodajProduktDoKoszyka(produkt, 1);
            }

            public void DodajDrugiProduktDoKoszyka()
            {
                koszyk.DodajProduktDoKoszyka(produkt2, 1);
            }

            public void UsunGornyProduktZKoszyka()
            {
                koszyk.UsunGornyProduktZKoszyka();
            }

            public void SprawdzCzyPustyKoszyk_Jeżeli_UsuniemyProduktZKoszykaZJednymProduktem()
            {
                bool czyProduktyWKoszyku = koszyk.Produkty.Any();

                Assert.IsFalse(czyProduktyWKoszyku);
            }

            //public void SprawdzCzyJestJedenProduktWKoszyku()
            //{
            //    int iloscProduktowWKoszyku = koszyk.Produkty.Count;
            //    Assert.AreEqual(iloscProduktowWKoszyku, 1);
            //}

            //public void SprawdzCzySaDwaProduktyWKoszyku()
            //{
            //    int iloscProduktowWKoszyku = koszyk.Produkty.Count;
            //    Assert.AreEqual(iloscProduktowWKoszyku, 2);
            //}

            //public void SprawdzCzySumaIlosciDwochTakichSamychProduktowWKoszyku()
            //{
            //    int iloscProduktowWKoszyku = koszyk.Produkty.Single().Ilosc;
            //    //int iloscProduktowWKoszyku = koszyk.Produkty.First(p => p.Produkcik.Id == 1).Ilosc;
            //    Assert.AreEqual(iloscProduktowWKoszyku, 2);
            //}

            //public void SprawdzCzyBrakSumyIlosciGdyDodamyInnyProduktJuzWystepujacyWKoszyku()
            //{
            //    int iloscProduktowWKoszyku = koszyk.Produkty.First(p => p.Produkcik.Id == 2).Ilosc;
            //    Assert.AreEqual(iloscProduktowWKoszyku, 1);
            //}
        }

    }
}
