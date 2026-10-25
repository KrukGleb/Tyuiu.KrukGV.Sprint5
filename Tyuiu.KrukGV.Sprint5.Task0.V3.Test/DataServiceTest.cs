using System.IO;
using Tyuiu.KrukGV.Sprint5.Task0.V3.Lib;

namespace Tyuiu.KrukGV.Sprint5.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            DataService ds = new DataService();
            ds.SaveToFileTextData(3);

            string path = Path.GetTempPath();
            path = Path.Combine(path, "OutPutFileTask0.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
