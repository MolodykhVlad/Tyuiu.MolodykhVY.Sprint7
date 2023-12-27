using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MolodykhVY.Sprint7.Project.V4.Lib;

namespace Tyuiu.MolodykhVY.Sprint7.Project.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromFileData()
        {
            string path = @"C:\Users\Vlad\source\repos\Tyuiu.MolodykhVY.Sprint7.V4\Tyuiu.MolodykhVY.Sprint7.Project.V4\bin\Debug\OutPutFileBooks.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
