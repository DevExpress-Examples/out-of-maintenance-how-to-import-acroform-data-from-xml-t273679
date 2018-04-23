using System.Windows.Forms;
using DevExpress.Pdf;

namespace ImportAcroForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            // Load a PDF document with AcroForm data.
            pdfViewer1.LoadDocument("..\\..\\InitialAcroForm.pdf");

            // Import the document from an XML format. 
            pdfViewer1.Import("..\\..\\FilledAcroForm.xml");

            // Save the imported document.
            pdfViewer1.SaveDocument("..\\..\\ImportedAcroForm.pdf");
        }
    }
}