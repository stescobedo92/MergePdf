using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergePdf
{
    public class MergePdfUtil
    {
        public static void MergeAndSavePdf(string pdf1Path, string pdf2Path, string outputPath)
        {
            using (FileStream fs = new FileStream(path: outputPath, FileMode.Create))
            {
                Document document = new Document();
                PdfSmartCopy copy = new PdfSmartCopy(document, fs);
                document.Open();

                AddPdfToDocument(pdf1Path, copy);
                AddPdfToDocument(pdf2Path, copy);

                document.Close();
            }
        }

        public static void AddPdfToDocument(string pdfPath, PdfSmartCopy copy)
        {
            using (PdfReader reader = new PdfReader(pdfPath))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    copy.AddPage(copy.GetImportedPage(reader, i));
                }
            }
        }
    }
}
