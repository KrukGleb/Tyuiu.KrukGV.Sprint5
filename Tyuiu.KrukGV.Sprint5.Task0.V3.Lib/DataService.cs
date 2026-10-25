using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO; 

namespace Tyuiu.KrukGV.Sprint5.Task0.V3.Lib
{
    public class DataService : ISprint5Task0V3
    {
        public string SaveToFileTextData(int x)
        {
            
            var y = -0.25*(x*x*x - 3*x*x+4);
            y = Math.Round(y, 3);
            string tempDir = Path.GetTempPath();
            string path = Path.Combine(tempDir, "OutPutFileTask0.txt");
            File.WriteAllText(path, y.ToString());
            return path;
        }

    }
}