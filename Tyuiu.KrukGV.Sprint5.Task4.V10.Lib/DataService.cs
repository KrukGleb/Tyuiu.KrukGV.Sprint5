using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KrukGV.Sprint5.Task4.V10.Lib
{
    public class DataService : ISprint5Task4V10
    {
        public double LoadFromDataFile(string path)
        {

            string strX = File.ReadAllText(path);
            strX = strX.Replace('.', ',');
            double x = Convert.ToDouble(strX);
            x = x * x * x * 1.2 * x + 2;
            return Math.Round(x, 3);
        }
    }
}