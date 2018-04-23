Imports System.Windows.Forms
Imports DevExpress.Pdf

Namespace ImportAcroForm
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

            ' Load a PDF document with AcroForm data.
            pdfViewer1.LoadDocument("..\..\InitialAcroForm.pdf")

            ' Import the document from an XML format. 
            pdfViewer1.Import("..\..\FilledAcroForm.xml")

            ' Save the imported document.
            pdfViewer1.SaveDocument("..\..\ImportedAcroForm.pdf")
        End Sub
    End Class
End Namespace