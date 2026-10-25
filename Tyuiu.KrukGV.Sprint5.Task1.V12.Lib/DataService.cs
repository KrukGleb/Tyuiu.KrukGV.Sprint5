using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KrukGV.Sprint5.Task1.V12.Lib
{
    public class DataService : ISprint5Task1V12
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {

            string tempDir = Path.GetTempPath();
            string path = Path.Combine(tempDir, "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
                File.Delete(path);


            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = (5 * x + 2.5) / (Math.Sin(x) - 2) + 2;
                y = Math.Round(y, 3);
                strY = Convert.ToString(y);

                if (x != stopValue)
                    File.AppendAllText(path, strY + Environment.NewLine);
                else
                    File.AppendAllText(path, strY);
            }

            return path;
        }
    }
}