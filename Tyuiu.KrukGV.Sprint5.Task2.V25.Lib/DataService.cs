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
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                        matrix[i, j] = 0;
                    info += matrix[i, j].ToString() + ";";
                }
                info += "\n";
            }

            File.AppendAllText(path, info);
            return path;
        }
    }
}