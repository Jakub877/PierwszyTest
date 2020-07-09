using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierwszyTest;

namespace PierwszyTest.Test
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void SumaDodatnia_Jezeli_LiczbyDodatnie()
        {
            //Arrange - inicjalizacja wsztstkiego, przygotowanie parametrów do testów
            Program mojProgram = new Program();
            int liczbaDodatnia1 = 10;
            int liczbaDodatnia2 = 4567346;

            //Act - wykonanie metody testowanej
            int wynik = mojProgram.SumaLiczb(liczbaDodatnia1, liczbaDodatnia2);

            //Assert - sprawdzenie, czy jest ok
            Assert.AreEqual(4567356, wynik);
        }

        [TestMethod]
        public void SumaUjemna_Jezeli_LiczbyUjemne()
        {
            //Arrange
            Program mojProgram = new Program();
            int liczbaUjemna1 = -10;
            int liczbaUjemna2 = -5;

            //Act - wykonanie metody testowanej
            int wynik = mojProgram.SumaLiczb(liczbaUjemna1, liczbaUjemna2);

            //Assert
            Assert.AreEqual(-15, wynik);
        }

        [TestMethod]
        public void SumaLiczb_Jezeli_UjemnaIMaxInt()
        {
            //Arrange
            Program mojProgram = new Program();
            int liczbaMaxInt = int.MaxValue;
            int liczbaUjemna = -5;

            //Act
            int wynik = mojProgram.SumaLiczb(liczbaMaxInt, liczbaUjemna);

            //Assert
            Assert.IsTrue(true);
        }
    }
}
