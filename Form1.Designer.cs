
namespace Emgu_openCV_Homework
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioG = new System.Windows.Forms.RadioButton();
            this.radioR = new System.Windows.Forms.RadioButton();
            this.ImgInput = new Emgu.CV.UI.ImageBox();
            this.ImgOutput = new Emgu.CV.UI.ImageBox();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgOutput)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImage.Location = new System.Drawing.Point(1147, 12);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(165, 57);
            this.btnLoadImage.TabIndex = 3;
            this.btnLoadImage.Text = "LoadImage";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioB);
            this.groupBox1.Controls.Add(this.radioG);
            this.groupBox1.Controls.Add(this.radioR);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1143, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 162);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histogram";
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioB.Location = new System.Drawing.Point(6, 108);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(68, 24);
            this.radioB.TabIndex = 3;
            this.radioB.TabStop = true;
            this.radioB.Text = "Blue";
            this.radioB.UseVisualStyleBackColor = true;
            this.radioB.CheckedChanged += new System.EventHandler(this.radioB_CheckedChanged_1);
            // 
            // radioG
            // 
            this.radioG.AutoSize = true;
            this.radioG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioG.Location = new System.Drawing.Point(6, 74);
            this.radioG.Name = "radioG";
            this.radioG.Size = new System.Drawing.Size(81, 24);
            this.radioG.TabIndex = 1;
            this.radioG.TabStop = true;
            this.radioG.Text = "Green";
            this.radioG.UseVisualStyleBackColor = true;
            this.radioG.CheckedChanged += new System.EventHandler(this.radioG_CheckedChanged);
            // 
            // radioR
            // 
            this.radioR.AutoSize = true;
            this.radioR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioR.Location = new System.Drawing.Point(6, 35);
            this.radioR.Name = "radioR";
            this.radioR.Size = new System.Drawing.Size(63, 24);
            this.radioR.TabIndex = 0;
            this.radioR.TabStop = true;
            this.radioR.Text = "Red";
            this.radioR.UseVisualStyleBackColor = true;
            this.radioR.CheckedChanged += new System.EventHandler(this.radioR_CheckedChanged);
            // 
            // ImgInput
            // 
            this.ImgInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgInput.Location = new System.Drawing.Point(3, 3);
            this.ImgInput.Name = "ImgInput";
            this.ImgInput.Size = new System.Drawing.Size(342, 313);
            this.ImgInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgInput.TabIndex = 2;
            this.ImgInput.TabStop = false;
            // 
            // ImgOutput
            // 
            this.ImgOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgOutput.Location = new System.Drawing.Point(3, 322);
            this.ImgOutput.Name = "ImgOutput";
            this.ImgOutput.Size = new System.Drawing.Size(342, 308);
            this.ImgOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgOutput.TabIndex = 5;
            this.ImgOutput.TabStop = false;
            // 
            // histogramBox1
            // 
            this.histogramBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histogramBox1.Location = new System.Drawing.Point(352, 3);
            this.histogramBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(784, 627);
            this.histogramBox1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1146, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 170);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ເລືອກແມ່ສີ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 42);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnForm2
            // 
            this.btnForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm2.Location = new System.Drawing.Point(1157, 476);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(161, 57);
            this.btnForm2.TabIndex = 7;
            this.btnForm2.Text = "Ex2";
            this.btnForm2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 632);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.ImgOutput);
            this.Controls.Add(this.ImgInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoadImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgOutput)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
     //   private Emgu.CV.UI.HistogramBox histogramBox1;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioG;
        private System.Windows.Forms.RadioButton radioR;
        private Emgu.CV.UI.ImageBox ImgInput;
        private Emgu.CV.UI.ImageBox ImgOutput;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnForm2;
    }
}

