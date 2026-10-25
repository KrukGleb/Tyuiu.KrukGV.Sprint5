
using Tyuiu.KrukGV.Sprint5.Task6.V9.Lib;

namespace Tyuiu.KrukGV.Sprint5.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Крук Г. В. | НТм25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Крук Глеб Владиславович | НТм25-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти количество слов длиной три символа в строке:                      *");
            Console.WriteLine("* Один, два, три – вперёд!                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            string path = @"C:\DataSprint5\InPutDataFileTask6V9.txt";
            string strX = File.ReadAllText(path);

            Console.WriteLine("Текст: " + strX);

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("*************************************************************************");

            int res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}