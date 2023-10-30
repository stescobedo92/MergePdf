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
