using TestFiles;

namespace Unit_Tests
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
            Assert.IsTrue(systemConfig.Count > 0);

        }
        [TestMethod]
        public void TestReadFileUsesValidFilePath()
        {
            string winDir = "C:\\Windows";
            string filePath = winDir + "\\system.ini";
            bool fileExists = File.Exists(filePath);
            Assert.IsTrue(fileExists);
        }

        [TestMethod]
        public void TestReadFileReturnsSystemConfigListWhenFileExists()
        {
            // Arrange
            List<string> expected = new List<string>
            {
                "; for 16-bit app support",
                "[386Enh]",
                "woafont=dosapp.fon",
                "EGA80WOA.FON=EGA80WOA.FON",
                "EGA40WOA.FON=EGA40WOA.FON",
                "CGA80WOA.FON=CGA80WOA.FON",
                "CGA40WOA.FON=CGA40WOA.FON",
                "",
                "[drivers]",
                "wave=mmdrv.dll",
                "timer=timer.drv",
                "",
                "[mci]"
            };


            // Act
            List<string> actual = Files.ReadFile();

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}