<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595799/15.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T273679)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ImportAcroForm/Form1.cs) (VB: [Form1.vb](./VB/ImportAcroForm/Form1.vb))
<!-- default file list end -->
# How to import AcroForm data from XML


<p>This example demonstrates how you can import AcroForm data  (interactive forms) from XML format  to a PDF document.</p>
<p>You can also import the AcroForm data from FDF, XFDF, and TXT formats as described below.<br /><br /></p>


<h3>Description</h3>

To import interactive forms from&nbsp;XML format: <br />- load an interactive forms&nbsp;document&nbsp;(e.g., from a file path), in which the data will be imported,&nbsp;into the PDF Viewer&nbsp;using the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPdfViewerPdfViewer_LoadDocumenttopic">PdfViewer.LoadDocument</a> method;<br />- call one of&nbsp;the&nbsp;<strong>PdfViewer.Import</strong>&nbsp;overloaded methods, for example, with a &nbsp;specified&nbsp;XML&nbsp;file&nbsp;that contains imported data.<br /><br />Note that&nbsp;you may need to add&nbsp;the <strong>DevExpress.Docs</strong> reference&nbsp;to your application to access the<strong> PdfViewer.Import</strong> extension&nbsp;methods.

<br/>


