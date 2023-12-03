using StockManagement.Entity;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.Utils
{
    public class Utils
    {
        public static void UploadImage(PictureBox pictureBox)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Files|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = ofd.FileName;
            }
        }

        public static string GetImagePath(PictureBox pictureBox)
        {
            string imagePath = @"C:\Users\fkoca\Desktop\StockManagement\StockManagement\Resources\";
            string defaultImage = "emptyProduct.jpg";
            string ProductImgPath;

            if (pictureBox.Image != null)
            {
                string imageName = Guid.NewGuid() + ".jpg";
                pictureBox.Image.Save(imagePath + imageName, ImageFormat.Jpeg);
                ProductImgPath = imagePath + imageName;
            }
            else
            {
                ProductImgPath = imagePath + defaultImage;
            }
            return ProductImgPath;
        }

        public static void ClearAllTextBox(List<TextBox> textboxs)
        {
            foreach (var item in textboxs)
            {
                item.Clear();
            }
        }
    }
}
