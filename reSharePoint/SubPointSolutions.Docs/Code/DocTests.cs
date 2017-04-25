using Microsoft.VisualStudio.TestTools.UnitTesting;
using SubPointSolutions.DocsBuildTools;
using SubPointSolutions.DocsBuildTools.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubPointSolutions.Docs.Code
{
    [TestClass]
    public class DocTests
    {
        [TestMethod]
        [TestCategory("CI.Core")]
        public void Can_CreateSamplesIndex()
        {
            var sampleIndexFolderName = "_sample_index";

            var assemblyPath = Path.GetDirectoryName(GetType().Assembly.Location);
            var rootPath = Path.GetFullPath(assemblyPath + "./../../");

            var srcViewFolderPath = Path.Combine(rootPath, "Views");
            var dstViewFolderPath = Path.Combine(rootPath, "Views/" + sampleIndexFolderName);

            Directory.CreateDirectory(dstViewFolderPath);

            var srcSubmodulesPaths = Directory.GetDirectories(srcViewFolderPath);

            foreach (var srcFolderPath in srcSubmodulesPaths)
            {
                var dirName = new DirectoryInfo(srcFolderPath).Name;

                if (dirName == sampleIndexFolderName)
                    continue;

                var dstFolderPath = Path.Combine(dstViewFolderPath, dirName);

                Directory.CreateDirectory(dstFolderPath);

                SampleWriteAPI.CreateSamplesIndex(srcFolderPath, dstFolderPath);
                var allSamples = SampleReadAPI.LoadSamples(dstFolderPath);

                Assert.IsNotNull(allSamples);
                Assert.IsTrue(allSamples.Count() > 0);
            }
        }
    }
}
