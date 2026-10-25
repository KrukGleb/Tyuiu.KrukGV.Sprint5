using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KrukGV.Sprint5.Task5.V17.Lib
{
    public class DataService : ISprint5Task5V17
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Replace('.', ',');
            string[] parts = strX.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            double sum = 0;
            double number;
            foreach (string part in parts)
            {
                number = Convert.ToDouble(part);
                if (number > 0)
                    sum += number;
            }
            return Math.Round(sum, 2);
            
        }
    }
}