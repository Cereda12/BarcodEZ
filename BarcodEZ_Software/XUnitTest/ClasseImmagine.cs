using System;
using System.Windows.Forms;
using System.Drawing;
using ZXing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodEZ_Software
{
    class ClasseImmagine
    {
        public static string Gallery(PictureBox pBox)
        {
            Bitmap bitmap = pBox.Image as Bitmap;
            BarcodeReader reader = new BarcodeReader();
            string cod = string.Empty;
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                cod=result.ToString();
                return cod;
            }
            else
            {
                return cod;
            }
        }
    }
}
