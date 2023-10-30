using iTextSharp.text;
using iTextSharp.text.pdf;
using MergePdf;

Console.WriteLine("Path to first PDF: ");
string pdf1Path = Console.ReadLine();

Console.WriteLine("Path to second PDF: ");
string pdf2Path = Console.ReadLine();

Console.WriteLine("Name of the new document: ");
string outputPath = Console.ReadLine();

MergePdfUtil.MergeAndSavePdf(pdf1Path, pdf2Path, outputPath);

Console.WriteLine("Documents successfully combined: " + outputPath);