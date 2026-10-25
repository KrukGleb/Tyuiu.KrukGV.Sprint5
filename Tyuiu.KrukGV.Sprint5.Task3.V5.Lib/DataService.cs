using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KrukGV.Sprint5.Task3.V5.Lib
{
    public class DataService : ISprint5Task3V5
    {
        public string SaveToFileTextData(int x)
        {
            string tempDir = Path.GetTempPath();
            string path = Path.Combine(tempDir, "OutPutFileTask3.bin");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
                File.Delete(path);

            double y = 2 * x * x * x + x * x / 2 - 3.5 * x + 2;
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}