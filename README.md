# MergePdf

MergePDF project is an PDF document merging application designed to simplify and expedite the combination of multiple PDF files into a single, organized document. This tool will provide users with an efficient solution for organizing, merging, and managing their PDF files with ease.

## Overview

This application allows you to merge two existing PDF documents into a new single PDF file. It utilizes the iTextSharp library for working with PDF files in C#.

## Prerequisites

-   .NET Framework installed on your machine.
-   iTextSharp library included in your project.

## How to Use

1.  Clone or download this repository to your local machine.
2.  Build the project using a .NET development environment.
3.  Run the compiled application.

## Instructions

When you run the application, it will prompt you for the following inputs:

1.  **Path to the first PDF**: Provide the file path to the first PDF document you want to merge.
2.  **Path to the second PDF**: Provide the file path to the second PDF document you want to merge.
3.  **Name of the new document**: Enter the name of the new merged PDF document.

The program will then merge the specified PDFs into a new document, and upon successful completion, it will display a message indicating that the documents have been successfully combined.

## Example

Here's an example of how to use the program:
```
Path to first PDF: C:\Documents\pdf1.pdf
Path to second PDF: C:\Documents\pdf2.pdf
Name of the new document: C:\Documents\merged.pdf

Documents successfully combined: C:\Documents\merged.pdf
```
## Note

Make sure you have the necessary permissions to read and write to the specified file paths. If the iTextSharp library is not already included in your project, you will need to add it for this code to work correctly.

## License

This project is open-source and available under the [MIT License](https://chat.openai.com/c/LICENSE). Feel free to modify and use it in your own projects.
