
using Tyuiu.KrukGV.Sprint5.Task1.V12.Lib;

namespace Tyuiu.KrukGV.Sprint5.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            ds.SaveToFileTextData(-5, 5);

            string path = Path.GetTempPath();
            path = Path.Combine(path, "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
