
using Tyuiu.KrukGV.Sprint5.Task2.V25.Lib;

namespace Tyuiu.KrukGV.Sprint5.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            DataService ds = new DataService();
            int[,] mtrx = {{ 4, 8, 5},{1, 4, 2},{4, 9, 9}};
            ds.SaveToFileTextData(mtrx);

            string path = Path.GetTempPath();
            path = Path.Combine(path, "OutPutFileTask2.csv");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
