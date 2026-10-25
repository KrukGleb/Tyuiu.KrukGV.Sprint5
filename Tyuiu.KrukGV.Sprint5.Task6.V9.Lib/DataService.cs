using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KrukGV.Sprint5.Task6.V9.Lib
{
    public class DataService : ISprint5Task6V9
    {
        public int LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Replace(",", "");
            string[] parts = strX.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int count = 0;
            foreach (string part in parts)
                if (part.Length == 3)
                    count++;

            return count;
        }
    }
}