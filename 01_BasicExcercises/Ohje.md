# Perustehtävät

Mallia voi katsoa esimerkiksi osoitteista: 
* https://learn.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022. Kyseistä tehtävää jatkokehitetään tehtävässä kaksi.
* https://learn.microsoft.com/en-us/visualstudio/test/unit-test-basics?view=vs-2022#write-your-tests

Kun teet metodiin testejä, niin testaa yhtä asiaa kerrallaan. Jos löydät toisen tapauksen, niin tee sille uusi testi.
Testaa tehtävissä seuraavia asioita:
Hyvän päivän "ns. good weather" tapaus eli, jos ohjelma laskee yhteen 2+2, niin testin oletustulos on 4 ja testit menevät läpi.
Huono tapaus eli "ns. bad weather", jos lasketaan 2-3 = -5, niin tulee virhe."Ei ole oikein."
Testaa lukujen rajat. Esimerkiksi neliöjuuri ei voi olla negatiivisesta luvusta.

## 1. Lukujen testaamista
 1.  Tee ohjelma, joka vähentää kaksi kokonaislukua(int) toisistaan ja palauttaa lopputuloksen. Luvut voivat olla negatiivisia. Tee ohjelmalle yksikkötestit.
 2. Tee ohjelma, joka ottaa syötteenä kokonaisluvun. Sallituin suurin arvo, jonka ohjelma käsittelee on 100. Ohjelma palauttaa luvun toisen potenssin (n^2). Tee ohjelmalle yksikkötestit.
 3. Tee ohjelma, joka ottaa syötteenä kokonaisluvun. Ohjelma palauttaa luvun neliöjuuren. Tee ohjelmalle yksikkötestit.

## 2. Etsi pienin, suurin, laske keskiarvo

1. Tee ohjelma, joka etsii double tyyppisestä listasta (List<double>) pienimmän arvon ja palauttaa sen. Tee ohjelmalle yksikköstestit.
2. Tee ohjelma, joka etsii int tyyppisestä listasta (List<int>) suurimman arvon ja palauttaa sen. Tee ohjelmalle yksikköstestit. 
3. Tee ohjelma, joka laskee float tyyppissen listan (List<float>) lukujen keskiarvon ja palauttaa sen. Tee ohjelmalle yksikköstestit. 


## 3. Tiedostojen testaaminen

Tee seuraavalle ohjelmalle testit. Tehtävänäsi on suunnitella lisää testejä alla olevalle ohjelmalle. Nyt testataan, onko listassa yhtään alkiota. Mitä muita testejä keksit?
```c#
using System.Reflection;
namespace TestFiles
{
    public class Files
    {
        public static void Main(string[] args)
        {
            List<string>systemConfig = ReadFile();
            PrintFile(systemConfig);
        }
        private static void PrintFile(List<string> systemConfig)
        {
            foreach (var item in systemConfig)
            {
                Console.WriteLine(item);
            }
        }
        public static List<string> ReadFile()
        {
            string winDir = "C:\\Windows";
            List<string> systemConfig = new List<string>();
            StreamReader reader = new StreamReader(winDir + "\\system.ini");
            try
            {
                do
                {
                    systemConfig.Add(reader.ReadLine());
                }
                while (reader.Peek() != -1);
            }
            catch
            {
                systemConfig.Add(("File is empty"));
            }
            finally
            {
                reader.Close();
            }
            return systemConfig;
        }
    }
}
Mallitesti:
using Microsoft.VisualStudio.TestPlatform.TestHost;
using TestFiles;
namespace FileTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReadFile_ReturnsListOfSettings_IfFileIsNotEmpty()
        {
            //Arrange
            List<string> systemConfig;
            //Act
            systemConfig = Files.ReadFile();
            //Assert
            Assert.IsTrue(systemConfig.Count < 0);
        }
    }
}
```
