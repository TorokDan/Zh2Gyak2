using System.IO;

namespace Zh2Gyak2
{
    static class FileHandler 
    {
        public static string srcPath { get; set; }
        public static string  dstPath { get; set; }

        public static string[] Load()
        {
            StreamReader sr = new StreamReader(srcPath);
            int i = 0;
            string[] tomb = new string[int.Parse(sr.ReadLine())];
            while (!sr.EndOfStream)
                tomb[i++] = sr.ReadLine();
            sr.Close();
            return tomb;
        }
        public static void Append(string hozzafuzendo)
        {
            StreamWriter sw = new StreamWriter(dstPath, true);
            sw.WriteLine(hozzafuzendo);
            sw.Close();
        }
    }
}
