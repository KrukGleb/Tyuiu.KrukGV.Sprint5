using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.KrukGV.Sprint5.Task7.V6.Lib
{
    public class DataService : ISprint5Task7V6
    {

        public string LoadDataAndSave(string path)
        {
            string strX = File.ReadAllText(path);
            string res = "";
            foreach (char c in strX)
                if (char.IsLetter(c) && (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z'))
                    res += '#'; 
                else
                    res += c;

            string tempDir = Path.GetTempPath();
            string path_out = Path.Combine(tempDir, "OutPutDataFileTask7V6.txt");

            FileInfo fileInfo = new FileInfo(path_out);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
                File.Delete(path_out);
            File.AppendAllText(path_out, res);

            return res;
        }
    }
}