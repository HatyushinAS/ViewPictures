using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewPictures
{
    public partial class ViewPicture : Form
    {
        private List<FileInfo> _imageList;
        private int _imageIndex;
        private ImageChanger imgChange;
        public ViewPicture()
        {
            InitializeComponent();
            _imageList = new List<FileInfo>();
            imgChange = new ImageChanger(pictureBox1);
        }
        private void TopButton_Click(object sender, EventArgs e)
        {
            var fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                var folder = new DirectoryInfo(fb.SelectedPath);
                _imageList = folder.GetFiles()
                    .Where(c => c.Extension == ".jpg"
                    || c.Extension == ".png")
                    .ToList();

                PictureList.Items.Clear();
                foreach (var item in _imageList)
                {
                    PictureList.Items.Add(item.Name);
                }
                DisplayImage();
            }
            else
            {
                MessageBox.Show("Выберете папку");
            }
        }

        private void DisplayImage()
        {
            var image = _imageList.ElementAtOrDefault(_imageIndex);
            if(image != null)
            {
                imgChange.LoadImage(image.FullName);
                imgChange.RenderImage();
                //pictureBox1.Image = Image.FromFile(image.FullName);
            }
        }

        private void PictureList_SelectedIndexChanged(object sender, EventArgs e)
        {
            _imageIndex = PictureList.SelectedIndex;
            DisplayImage();
        }

        private void ButtonImageChange(object sender, EventArgs e)
        {
            var button = sender as Button;
            switch (button.Name)
            {
                case "LeftButton":
                    _imageIndex--;
                    break;
                case "RightButton":
                    _imageIndex++;
                    break;
            }
            if (_imageIndex < 0)
            {
                _imageIndex = 0;
                return;
            }
            if (_imageIndex > _imageList.Count() - 1)
            {
                _imageIndex = _imageList.Count() - 1;
                return;
            }
            DisplayImage();
        }

        private void trackBarBright_Scroll(object sender, EventArgs e)
        {
            imgChange.b = trackBarBright.Value * 0.01f;
            imgChange.RenderImage();
        }
        private void checkBoxGray_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                imgChange.gray = true;
                imgChange.RenderImage();
            }
            else
            {
                imgChange.gray = false;
                imgChange.RenderImage();
            }
        }

        private void checkBoxNoise_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                imgChange.noise = true;
                imgChange.RenderImage();
            }
            else
            {
                imgChange.noise = false;
                imgChange.RenderImage();
            }
        }
    }
}
