using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZXing
{
    public partial class Form1 : Form
    {
        /*
         *
         * SAMPLE VCARD
BEGIN:VCARD
N:BobLastName;BobFirstName
ORG:eLynx
TITLE:Sr. Software Developer
TEL:999-999-9999
EMAIL:ununun@unun.com
URL:www.ununununun.com
ADR:;;9111 SW Gemini Drive Suite E;Beaverton;OR;98660;
END:VCARD

         * 
         */

        private Bitmap qrCodeImage;

        public Form1()
        {
            InitializeComponent();
        }

        public Bitmap GenerateQR(int width, int height, string text)
        {
            int qubeDim = Math.Min(width, height);
            var bw = new ZXing.BarcodeWriter();
            var encOptions = new ZXing.Common.EncodingOptions() { Width = qubeDim, Height = qubeDim, Margin = 0 };
            bw.Options = encOptions;
            bw.Format = ZXing.BarcodeFormat.QR_CODE;
            var result = new Bitmap(bw.Write(text));

            return result;
        }

        private void updateImage()
        {
            string text = tbInput.Text;
            qrCodeImage = GenerateQR(pboxQRCode.Width, pboxQRCode.Height, text);
            pboxQRCode.Image = qrCodeImage;
        }

        private void tbGenerate_Click(object sender, EventArgs e)
        {
            updateImage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbInput.Text = "Bazinga!!!";
            updateImage();

        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            updateImage();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitializeLifetimeService();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";

            DialogResult ret = STAShowDialog(saveFileDialog1);

            if (ret != DialogResult.OK)
                return;

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        qrCodeImage.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        qrCodeImage.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        qrCodeImage.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }

        private DialogResult STAShowDialog(SaveFileDialog dialog)
        {

            DialogState state = new DialogState();

            state.dialog = dialog;
            System.Threading.Thread t = new System.Threading.Thread(state.ThreadProcShowDialog);
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
            t.Join();
            return state.result;

        }


    }
}
