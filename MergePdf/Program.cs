using iTextSharp.text;
using iTextSharp.text.pdf;

Console.WriteLine("Path to first PDF: ");
string pdf1Path = Console.ReadLine();

Console.WriteLine("Path to second PDF: ");
string pdf2Path = Console.ReadLine();

Console.WriteLine("Name of the new document: ");
string outputPath = Console.ReadLine();

using (FileStream fs = new FileStream(path: outputPath, FileMode.Create))
{
    Document document = new Document();
    PdfSmartCopy copy = new PdfSmartCopy(document, fs);
    document.Open();

    AddPdfToDocument(pdf1Path, copy);
    AddPdfToDocument(pdf2Path, copy);

    document.Close();
}

Console.WriteLine("Documents successfully combined: " + outputPath);
static void AddPdfToDocument(string pdfPath, PdfSmartCopy copy)
{
    using (PdfReader reader = new PdfReader(pdfPath))
    {
        for (int i = 1; i <= reader.NumberOfPages; i++)
        {
            copy.AddPage(copy.GetImportedPage(reader, i));
        }
    }
}
