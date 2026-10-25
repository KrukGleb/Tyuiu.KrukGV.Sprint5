
using Tyuiu.KrukGV.Sprint5.Task6.V9.Lib;

namespace Tyuiu.KrukGV.Sprint5.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V9.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

            DataService ds = new DataService();
            var y = ds.LoadFromDataFile(path);
            Assert.AreEqual(2, y);
        }
    }
}
