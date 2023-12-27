using MergePdf;

namespace MergePdfTest
{
    [TestFixture]
    public class MergePdfUnitTest
    {
        [Test]
        public void Test_MergeTwoPdfs_Success()
        {            
            string pdf1Path = "vs-1.pdf";
            string pdf2Path = "vs-2.pdf";
            string outputPath = "output.pdf";

            MergePdfUtil.MergeAndSavePdf(pdf1Path, pdf2Path, outputPath);

            Assert.True(File.Exists(outputPath));
        }
    }
}