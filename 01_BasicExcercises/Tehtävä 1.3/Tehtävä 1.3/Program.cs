using System.Reflection;
namespace TestFiles
{
    public class Files
    {
        public static void Main(string[] args)
        {
            List<string> systemConfig = ReadFile();
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