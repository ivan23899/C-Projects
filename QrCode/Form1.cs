using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace QrCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            BarcodeWriter barcodewriter = new BarcodeWriter();
            barcodewriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodewriter.Write(txtMensaje.Text);
            picQr.Image = bitmap;

            LuminanceSource source = new BitmapLuminanceSource(bitmap);
            BinaryBitmap binaryBitmap = new BinaryBitmap(new HybridBinarizer(source));
            Result result = new MultiFormatReader().decode(binaryBitmap);
            MessageBox.Show(result.Text);
        }
    }
}
