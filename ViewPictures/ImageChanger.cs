using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewPictures
{
    class ImageChanger
    {
        private Image _original { get; set; }
        private PictureBox _pictureBox { get; set; }
        private ColorMatrix _brightness { get; set; }
        private ColorMatrix _gray { get; set; }
        public float b { get; set; }
        public bool gray { get; set; }
        public bool noise { get; set; }
        public ImageChanger(PictureBox pictureBox)
        {
            this._pictureBox = pictureBox;
            gray = false;
            noise = false;
        }
        public void ChangeMatrix()
        {
            _brightness = new ColorMatrix(new float[][]
            {
                new float [] {1, 0, 0, 0, 0},
                new float [] {0, 1, 0, 0, 0},
                new float [] {0, 0, 1, 0, 0},
                new float [] {0, 0, 0, 1, 0},
                new float [] {b, b, b, 0, 1},
            });

            _gray = new ColorMatrix(new float[][]
            {
                new float[] { 0.299f, 0.299f, 0.299f, 0, 0 },
                new float[] { 0.587f, 0.587f, 0.587f, 0, 0 },
                new float[] { 0.114f, 0.114f, 0.114f, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { b, b, b, 0, 1 },
            });
        }
        private Bitmap CreateNoise(ref Bitmap image)
        {
            Random rnd = new Random();

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color color = image.GetPixel(i, j);
                    byte r = (byte)(rnd.Next(0, 2) == 1 ? color.R : 255);
                    byte b = (byte)(rnd.Next(0, 2) == 1 ? color.B : 255);
                    byte g = (byte)(rnd.Next(0, 2) == 1 ? color.G : 255);

                    image.SetPixel(i, j, Color.FromArgb(255, r, g, b));
                }
            }
            return image;
        }
        public void LoadImage(string path)
        {
            if (_original != null)
                _original.Dispose();
            _original = Image.FromFile(path);
        }
        public void RenderImage()
        {
            if (_original == null) return;

            if (_pictureBox.Image != null) _pictureBox.Image.Dispose();

            var image = new Bitmap(_original.Width, _original.Height);
            ChangeMatrix();
            using (Graphics g = Graphics.FromImage(image))
            {
                ImageAttributes attr = new ImageAttributes();
                if (!gray)
                {
                    attr.SetColorMatrix(_brightness);
                }
                else
                {
                    attr.SetColorMatrix(_gray);
                }

                Rectangle rect = new Rectangle(0, 0, _original.Width, _original.Height);
                g.DrawImage(_original, rect, 0, 0, _original.Width, _original.Height, GraphicsUnit.Pixel, attr);
            }
            if (noise)
            {
                _pictureBox.Image = CreateNoise(ref image);
                return;
            }

            _pictureBox.Image = image;
        }
    }
}
