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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image< Bgr, byte> oriImage;
        Image<Gray, byte> R, G, B ;
        

        private void radioR_CheckedChanged(object sender, EventArgs e)
        {
            if (radioR.Checked)
            {
                ImgOutput.Image = R;
                histogramBox1.ClearHistogram();
                histogramBox1.GenerateHistograms(R, 256);
                histogramBox1.Refresh();
                MessageBox.Show("Gray from Blue Channel RadioR");
            }



        }

        private void radioG_CheckedChanged(object sender, EventArgs e)
        {
            if (radioG.Checked)
            {
                ImgOutput.Image = G;
                histogramBox1.ClearHistogram();
                histogramBox1.GenerateHistograms(G, 256);
                histogramBox1.Refresh();
                MessageBox.Show(" Gray is form Green Chanel RadioG");
            }
        }

        private void radioB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioB.Checked)
            {
                ImgOutput.Image = B;
                histogramBox1.ClearHistogram();
                histogramBox1.GenerateHistograms(B, 256);
                histogramBox1.Refresh();
                MessageBox.Show(" Gray is form Blue Chanel RadioB");
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Red")
            {
                ImgOutput.Image = R;
                histogramBox1.ClearHistogram();
                histogramBox1.GenerateHistograms(R, 256);
                histogramBox1.Refresh();
                MessageBox.Show(" Gray is form Red Chanel  CoboBoxR");
            }
            else if (comboBox1.SelectedItem == "Green")
            {
                ImgOutput.Image = G;
                histogramBox1.ClearHistogram();
                histogramBox1.GenerateHistograms(G, 256);
                histogramBox1.Refresh();
                MessageBox.Show(" Gray is form Green Chanel CoboBoxG");
            }

            else if (comboBox1.SelectedItem == "Blue")
            {
                ImgOutput.Image = B;
                histogramBox1.ClearHistogram();
                histogramBox1.GenerateHistograms(B, 256);
                histogramBox1.Refresh();
                MessageBox.Show(" Gray is form Blue Chanel  CoboBoxB");
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                oriImage = new Image<Bgr, byte>(openDialog.FileName);
                B = oriImage[0];
                G = oriImage[1];
                R = oriImage[2];
                ImgInput.Image = oriImage;

                if (radioR.Checked)
                {
                    ImgOutput.Image = R;
                    histogramBox1.ClearHistogram();
                    histogramBox1.GenerateHistograms(R, 256);
                    histogramBox1.Refresh();
                    MessageBox.Show(" Gray is form Red Chanel Radio");
                }
                else if (radioG.Checked)
                {
                    ImgOutput.Image = G;
                    histogramBox1.ClearHistogram();
                    histogramBox1.GenerateHistograms(G, 256);
                    histogramBox1.Refresh();
                    MessageBox.Show(" Gray is form Green Chanel Radio");
                }
                else if (radioB.Checked)
                {
                    ImgOutput.Image = B;
                    histogramBox1.ClearHistogram();
                    histogramBox1.GenerateHistograms(B, 256);
                    histogramBox1.Refresh();
                    MessageBox.Show(" Gray is form Blue Chanel Radio");
                }

                if (comboBox1.SelectedItem == "Red")
                {
                    ImgOutput.Image = R;
                    histogramBox1.ClearHistogram();
                    histogramBox1.GenerateHistograms(R, 256);
                    histogramBox1.Refresh();
                    MessageBox.Show(" Gray is form Red Chanel CoboBox");
                }
                else if (comboBox1.SelectedItem == "Green")
                {
                    ImgOutput.Image = G;
                    histogramBox1.ClearHistogram();
                    histogramBox1.GenerateHistograms(G, 256);
                    histogramBox1.Refresh();
                    MessageBox.Show(" Gray is form Green Chanel CoboBox");
                }

                else if  (comboBox1.SelectedItem == "Blue")
                {
                    ImgOutput.Image = B;
                    histogramBox1.ClearHistogram();
                    histogramBox1.GenerateHistograms(B, 256);
                    histogramBox1.Refresh();
                    MessageBox.Show(" Gray is form Blue Chanel CoboBox");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            // radiobutton
           // radioB.Checked = true;

            // coboBox
            comboBox1.Items.Add("Red");
            comboBox1.Items.Add("Green");
            comboBox1.Items.Add("Blue");
            
            

        }
    }
}
