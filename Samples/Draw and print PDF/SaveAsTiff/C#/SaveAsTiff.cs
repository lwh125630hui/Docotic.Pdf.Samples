using System.Diagnostics;

using BitMiracle.Docotic.Pdf;

namespace BitMiracle.Docotic.Pdf.Samples
{
    public static class SaveAsTiff
    {
        public static void Main()
        {
            // NOTE: 
            // When used in trial mode, the library imposes some restrictions.
            // Please visit http://bitmiracle.com/pdf-library/trial-restrictions.aspx
            // for more information.
            
            string outputPath = "SaveAsTiff.tiff";

            using (var pdf = new PdfDocument(@"Sample Data\jfif3.pdf"))
            {
                PdfDrawOptions options = PdfDrawOptions.Create();
                options.BackgroundColor = new PdfRgbColor(255, 255, 255);

                pdf.SaveAsTiff(outputPath, options);
            }

            Process.Start(outputPath);
        }
    }
}
