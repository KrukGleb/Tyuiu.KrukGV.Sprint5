
using Tyuiu.KrukGV.Sprint5.Task7.V6.Lib;

namespace Tyuiu.KrukGV.Sprint5.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V6.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

            DataService ds = new DataService();
            string res = ds.LoadDataAndSave(path);

            string tempDir = Path.GetTempPath();
            string path_out = Path.Combine(tempDir, "OutPutDataFileTask7V6.txt");

            fileInfo = new FileInfo(path_out);
            fileExists = fileInfo.Exists;
            wait = true;
            Assert.AreEqual(wait, fileExists);
            Assert.AreEqual("Привет, #####! #### моя Первая программа.", res);
        }
    }
}
