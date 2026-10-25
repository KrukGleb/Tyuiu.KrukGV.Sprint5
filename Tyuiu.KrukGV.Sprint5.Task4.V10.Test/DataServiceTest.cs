
using Tyuiu.KrukGV.Sprint5.Task4.V10.Lib;

namespace Tyuiu.KrukGV.Sprint5.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V10.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

            DataService ds = new DataService();
            var y = ds.LoadFromDataFile(path);
            Assert.AreEqual(69.637, y);
        }
    }
}
