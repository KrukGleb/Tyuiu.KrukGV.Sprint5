using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KrukGV.Sprint5.Task2.V25.Lib
{
    public class DataService : ISprint5Task2V25
    {
       
        public string SaveToFileTextData(int[,] matrix)
        {
            string tempDir = Path.GetTempPath();
            string path = Path.Combine(tempDir, "OutPutFileTask2.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
                File.Delete(path);

            string info = "";
            int len = 3;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                        matrix[i, j] = 0;
                    
                    info += matrix[i, j].ToString();
                    if (j < len - 1)
                        info += ";";
                }
                info += "\n";
            }

            File.AppendAllText(path, info);
            return path;
        }
    }
}