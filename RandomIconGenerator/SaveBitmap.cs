using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace RandomIconGenerator
{
    class SaveBitmap
    {
        public string Path { get; set; }


        /// <summary>
        /// Opens the SaveAs Dialog with options to save as png
        /// </summary>
        /// <param name="icon">Bitmap icon</param>
        public void SaveAs(Bitmap icon)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = "icon";
            saveFileDialog.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    icon.Save(myStream, ImageFormat.Png);
                    myStream.Close();
                }
            }
        }
    }
}
