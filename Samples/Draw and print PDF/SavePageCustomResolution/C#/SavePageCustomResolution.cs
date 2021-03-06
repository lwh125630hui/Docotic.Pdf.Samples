using System.Diagnostics;

using BitMiracle.Docotic.Pdf;

namespace BitMiracle.Docotic.Pdf.Samples
{
    public static class SavePageCustomResolution
    {
        public static void Main()
        {
            // NOTE: 
            // When used in trial mode, the library imposes some restrictions.
            // Please visit http://bitmiracle.com/pdf-library/trial-restrictions.aspx
            // for more information.

            string pathToImage = "SavePageCustomResolution.png";

            using (PdfDocument pdf = new PdfDocument(@"Sample Data\gmail-cheat-sheet.pdf"))
            {
                PdfDrawOptions options = PdfDrawOptions.Create();
                options.BackgroundColor = new PdfRgbColor(255, 255, 255);
                options.HorizontalResolution = 600;
                options.VerticalResolution = 600;

                pdf.Pages[0].Save(pathToImage, options);
            }

            Process.Start(pathToImage);
        }
    }
}
