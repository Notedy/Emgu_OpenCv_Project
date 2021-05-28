using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Emgu_openCV_Homework
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

           
        }
        Image<Bgr, byte> oriImage;
        Image<Gray, byte> GrayImage, BinaryImage;
        int param1;
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                BinaryImage = GrayImage.ThresholdBinary(new Gray(150), new Gray(255));
                ImgBinary.Image = BinaryImage;
            }
            else if  (comboBox1.SelectedIndex == 1)
            {
                BinaryImage = GrayImage.ThresholdBinaryInv(new Gray(150), new Gray(255));
                ImgBinary.Image = BinaryImage;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                BinaryImage = GrayImage.ThresholdToZero(new Gray(150));
                ImgBinary.Image = BinaryImage;
            }
            else if  (comboBox1.SelectedIndex == 3)
            {
                BinaryImage = GrayImage.ThresholdAdaptive(new Gray(255), Emgu.CV.CvEnum.AdaptiveThresholdType.GaussianC, Emgu.CV.CvEnum.ThresholdType.Binary, 7, new Gray(14));
                ImgBinary.Image = BinaryImage;
            }
            else
            {
                BinaryImage = GrayImage.ThresholdAdaptive(new Gray(255), Emgu.CV.CvEnum.AdaptiveThresholdType.MeanC, Emgu.CV.CvEnum.ThresholdType.Binary, 7, new Gray(14));
                ImgBinary.Image = BinaryImage;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = " Save Binaty Image";
            sf.DefaultExt = "*.jpg";
            sf.Filter = " Jpeg Files (*.jpg)|*.jpg| PNG Files (*.png)|*.png| BMP Files (*.bmp)|*.bmp";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                ImgBinary.Image.Save(sf.FileName);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maxvalue_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                BinaryImage = GrayImage.ThresholdBinary(new Gray(150), new Gray(255));
                ImgBinary.Image = BinaryImage;
                ImgBinary.Refresh();
            }
            else if (textBox1.Text == "2")
            {

                BinaryImage = GrayImage.ThresholdBinaryInv(new Gray(150), new Gray(255));
                ImgBinary.Image = BinaryImage;
                ImgBinary.Refresh();
            }
            else if (textBox1.Text == "3")
            {
                BinaryImage = GrayImage.ThresholdToZero(new Gray(150));
                ImgBinary.Image = BinaryImage;
                ImgBinary.Refresh();

            }
            else if (textBox1.Text == "4")
            {
                BinaryImage = GrayImage.ThresholdAdaptive(new Gray(255), Emgu.CV.CvEnum.AdaptiveThresholdType.GaussianC, Emgu.CV.CvEnum.ThresholdType.Binary, 7, new Gray(14));
                ImgBinary.Image = BinaryImage;
            }
            else if (textBox1.Text == "5"){
                BinaryImage = GrayImage.ThresholdAdaptive(new Gray(255), Emgu.CV.CvEnum.AdaptiveThresholdType.MeanC, Emgu.CV.CvEnum.ThresholdType.Binary, 7, new Gray(14));
                ImgBinary.Image = BinaryImage;
            }
        }

        private void BlockSize_TextChanged(object sender, EventArgs e)
        {
             if (textBox2.Text == "1")
            {
                BinaryImage = GrayImage.ThresholdAdaptive(new Gray(255), Emgu.CV.CvEnum.AdaptiveThresholdType.GaussianC, Emgu.CV.CvEnum.ThresholdType.Binary, 7, new Gray(14));
                ImgBinary.Image = BinaryImage;
                param1 = Convert.ToInt32(Param1.Value);
                Param1.Value = (1);
            }
            else if (textBox2.Text == "2")
            {
                BinaryImage = GrayImage.ThresholdAdaptive(new Gray(255), Emgu.CV.CvEnum.AdaptiveThresholdType.MeanC, Emgu.CV.CvEnum.ThresholdType.Binary, 7, new Gray(14));
                ImgBinary.Image = BinaryImage;
               param1 = Convert.ToInt32(Param1.Value);
                Param1.Value = (2);
            }

        }

        private void Param_ValueChanged(object sender, EventArgs e)
        {
            if(Param1.Value == (1))
            {
                BinaryImage = GrayImage.ThresholdAdaptive(new Gray(255), Emgu.CV.CvEnum.AdaptiveThresholdType.GaussianC, Emgu.CV.CvEnum.ThresholdType.Binary, 7, new Gray(14));
                ImgBinary.Image = BinaryImage;
                param1 = Convert.ToInt32(Param1.Value);
                Param1.Value = (1);
            }
            else if (Param1.Value == (2))
            {
                BinaryImage = GrayImage.ThresholdAdaptive(new Gray(255), Emgu.CV.CvEnum.AdaptiveThresholdType.MeanC, Emgu.CV.CvEnum.ThresholdType.Binary, 7, new Gray(14));
                ImgBinary.Image = BinaryImage;
                param1 = Convert.ToInt32(Param1.Value);
                Param1.Value = (2);
            }
            else if (Param1.Value == (3))
            {
                BinaryImage = GrayImage.ThresholdAdaptive(new Gray(255), Emgu.CV.CvEnum.AdaptiveThresholdType.GaussianC, Emgu.CV.CvEnum.ThresholdType.Binary, 7, new Gray(20));
                ImgBinary.Image = BinaryImage;              
            }
            else if (Param1.Value == (4))
            {
                BinaryImage = GrayImage.ThresholdAdaptive(new Gray(255), Emgu.CV.CvEnum.AdaptiveThresholdType.MeanC, Emgu.CV.CvEnum.ThresholdType.Binary, 7, new Gray(20));
                ImgBinary.Image = BinaryImage;
               
            }
            else if (Param1.Value == (5))
            {
                BinaryImage = GrayImage.ThresholdAdaptive(new Gray(255), Emgu.CV.CvEnum.AdaptiveThresholdType.GaussianC, Emgu.CV.CvEnum.ThresholdType.Binary, 7, new Gray(30));
                ImgBinary.Image = BinaryImage;
            }
            else if (Param1.Value == (6))
            {
                BinaryImage = GrayImage.ThresholdAdaptive(new Gray(255), Emgu.CV.CvEnum.AdaptiveThresholdType.MeanC, Emgu.CV.CvEnum.ThresholdType.Binary, 7, new Gray(30));
                ImgBinary.Image = BinaryImage;
            }
            else if (Param1.Value == (7))
            {
                BinaryImage = GrayImage.ThresholdAdaptive(new Gray(255), Emgu.CV.CvEnum.AdaptiveThresholdType.GaussianC, Emgu.CV.CvEnum.ThresholdType.Binary, 7, new Gray(40));
                ImgBinary.Image = BinaryImage;
            }
            else if (Param1.Value == (8))
            {
                BinaryImage = GrayImage.ThresholdAdaptive(new Gray(255), Emgu.CV.CvEnum.AdaptiveThresholdType.MeanC, Emgu.CV.CvEnum.ThresholdType.Binary, 7, new Gray(40));
                ImgBinary.Image = BinaryImage;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                oriImage = new Image<Bgr, byte>(opf.FileName);
                ImgInput.Image = oriImage;
                GrayImage = oriImage.Convert<Gray, byte>();
                ImgGray.Image = GrayImage;
                ImgBinary.Image = null;
                comboBox1.SelectedText = "ເລືອກຮູບແບບຂາວດໍາ";
            }
        }
    }
}
