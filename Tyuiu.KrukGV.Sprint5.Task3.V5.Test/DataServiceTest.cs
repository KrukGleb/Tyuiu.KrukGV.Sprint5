
using Tyuiu.KrukGV.Sprint5.Task3.V5.Lib;

namespace Tyuiu.KrukGV.Sprint5.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            DataService ds = new DataService();
            
            ds.SaveToFileTextData(2);

            string path = Path.GetTempPath();
            path = Path.Combine(path, "OutPutFileTask3.bin");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                byte[] bytes = reader.ReadBytes(8);
                double y = BitConverter.ToDouble(bytes, 0);

                Assert.AreEqual(13, y);
            }
        }
    }
}
