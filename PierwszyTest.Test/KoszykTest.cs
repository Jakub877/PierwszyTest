using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PierwszyTest.Test
{
    [TestClass]
    public class KoszykTest
    {
        private Narzedzia logika;

        public KoszykTest()
        {
            logika = new Narzedzia();
        }

        [TestMethod]
        public void CzyJedenProduktWKoszyku_Jeżeli_DodamyProduktDoPustegoKoszyka()
        {
            //Arrange
            logika.UtworzKoszyk();
            logika.StworzProdukt();

            //Act
            logika.DodajPierwszyProduktDoKoszyka();

            //Assert
            logika.SprawdzCzyJestJedenProduktWKoszyku();
        }

        [TestMethod]
        public void CzyDwaProduktyWKoszyku_Jeżeli_DodamyDwaProduktyDoPustegoKoszyka()
        {
            //Arrange
            logika.UtworzKoszyk();
            logika.StworzProdukt();
            logika.StworzDrugiProdukt();

            //Act
            logika.DodajPierwszyProduktDoKoszyka();
            logika.DodajDrugiProduktDoKoszyka();

            //Assert
            logika.SprawdzCzySaDwaProduktyWKoszyku();
        }

        [TestMethod]
        public void CzyJedenProduktWKoszyku_Jeżeli_DodamyDwaRazyTenSamProdukt()
        {
            //Arrange
            logika.UtworzKoszyk();
            logika.StworzProdukt();

            //Act
            logika.DodajPierwszyProduktDoKoszyka();
            logika.DodajPierwszyProduktDoKoszyka();

            //Assert
            logika.SprawdzCzyJestJedenProduktWKoszyku();
        }

        [TestMethod]
        public void CzySumaIlosci_Jeżeli_DodamyDwaRazyTenSamProdukt()
        {
            //Arrange
            logika.UtworzKoszyk();
            logika.StworzProdukt();

            //Act
            logika.DodajPierwszyProduktDoKoszyka();
            logika.DodajPierwszyProduktDoKoszyka();

            //Assert
            logika.SprawdzCzySumaIlosciDwochTakichSamychProduktowWKoszyku();
        }

        [TestMethod]
        public void CzyBrakSumyIlosci_Jeżeli_DodamyInnyProduktJuzWystepujacyWKoszyku()
        {
            //Arrange
            logika.UtworzKoszyk();
            logika.StworzProdukt();
            logika.StworzDrugiProdukt();
            //Act
            logika.DodajPierwszyProduktDoKoszyka();
            logika.DodajDrugiProduktDoKoszyka();
            logika.DodajPierwszyProduktDoKoszyka();

            //Assert
            logika.SprawdzCzyBrakSumyIlosciGdyDodamyInnyProduktJuzWystepujacyWKoszyku();
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

            public void SprawdzCzyJestJedenProduktWKoszyku()
            {
                int iloscProduktowWKoszyku = koszyk.Produkty.Count;
                Assert.AreEqual(iloscProduktowWKoszyku, 1);
            }

            public void SprawdzCzySaDwaProduktyWKoszyku()
            {
                int iloscProduktowWKoszyku = koszyk.Produkty.Count;
                Assert.AreEqual(iloscProduktowWKoszyku, 2);
            }

            public void SprawdzCzySumaIlosciDwochTakichSamychProduktowWKoszyku()
            {
                int iloscProduktowWKoszyku = koszyk.Produkty.Single().Ilosc;
                //int iloscProduktowWKoszyku = koszyk.Produkty.First(p => p.Produkcik.Id == 1).Ilosc;
                Assert.AreEqual(iloscProduktowWKoszyku, 2);
            }

            public void SprawdzCzyBrakSumyIlosciGdyDodamyInnyProduktJuzWystepujacyWKoszyku()
            {
                int iloscProduktowWKoszyku = koszyk.Produkty.First(p => p.Produkcik.Id == 2).Ilosc;
                Assert.AreEqual(iloscProduktowWKoszyku, 1);
            }
        }
    }
}
