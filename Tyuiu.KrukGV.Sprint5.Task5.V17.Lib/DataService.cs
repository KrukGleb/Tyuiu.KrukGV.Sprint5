using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KrukGV.Sprint5.Task5.V17.Lib
{
    public class DataService : ISprint5Task5V17
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            string[] parts = strX.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;
            int temp;
            foreach (string part in parts)
            {
                if (int.TryParse(part, out temp))
                    sum += temp;
              }
            return sum;
            
        }
    }
}