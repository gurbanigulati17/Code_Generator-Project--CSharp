#region Assembly zxing, Version=0.16.5.0, Culture=neutral, PublicKeyToken=4e88037ac681fe60
// C:\Users\geetg\source\repos\BarCodeGenerator\packages\ZXing.Net.0.16.5\lib\net47\zxing.dll
#endregion
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



namespace BarCodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            var reader = new ZXing.BarcodeReader();
            var result = reader.Decode((Bitmap)pic.Image);
            if (result != null)
            {
                txtDecode.Text = result.ToString();
            }

        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.QR_CODE };
            pic.Image = writer.Write(txtEncode.Text);
            BarcodeWriter writer1 = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            pict.Image = writer1.Write(txtEncode.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
