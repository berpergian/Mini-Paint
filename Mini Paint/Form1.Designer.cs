namespace Mini_Paint
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtXA = new System.Windows.Forms.TextBox();
            this.txtYA = new System.Windows.Forms.TextBox();
            this.txtXB = new System.Windows.Forms.TextBox();
            this.txtYB = new System.Windows.Forms.TextBox();
            this.rbtnNaive = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnBresenham = new System.Windows.Forms.RadioButton();
            this.rbtnDDA = new System.Windows.Forms.RadioButton();
            this.rbtnNGon = new System.Windows.Forms.RadioButton();
            this.rbtnBintang = new System.Windows.Forms.RadioButton();
            this.rbtnElips = new System.Windows.Forms.RadioButton();
            this.rbtnLingkaran = new System.Windows.Forms.RadioButton();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReflectYminX = new System.Windows.Forms.Button();
            this.btnReflectYX = new System.Windows.Forms.Button();
            this.btnReflectY = new System.Windows.Forms.Button();
            this.txtRotate = new System.Windows.Forms.TextBox();
            this.btnReflectX = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnScale = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDeltaY = new System.Windows.Forms.TextBox();
            this.txtDeltaX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 258);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Y";
            // 
            // txtXA
            // 
            this.txtXA.Location = new System.Drawing.Point(28, 331);
            this.txtXA.Name = "txtXA";
            this.txtXA.Size = new System.Drawing.Size(33, 19);
            this.txtXA.TabIndex = 8;
            // 
            // txtYA
            // 
            this.txtYA.Location = new System.Drawing.Point(85, 331);
            this.txtYA.Name = "txtYA";
            this.txtYA.Size = new System.Drawing.Size(33, 19);
            this.txtYA.TabIndex = 9;
            // 
            // txtXB
            // 
            this.txtXB.Location = new System.Drawing.Point(151, 331);
            this.txtXB.Name = "txtXB";
            this.txtXB.Size = new System.Drawing.Size(33, 19);
            this.txtXB.TabIndex = 10;
            // 
            // txtYB
            // 
            this.txtYB.Location = new System.Drawing.Point(208, 331);
            this.txtYB.Name = "txtYB";
            this.txtYB.Size = new System.Drawing.Size(33, 19);
            this.txtYB.TabIndex = 11;
            // 
            // rbtnNaive
            // 
            this.rbtnNaive.AutoSize = true;
            this.rbtnNaive.Location = new System.Drawing.Point(12, 18);
            this.rbtnNaive.Name = "rbtnNaive";
            this.rbtnNaive.Size = new System.Drawing.Size(52, 16);
            this.rbtnNaive.TabIndex = 28;
            this.rbtnNaive.TabStop = true;
            this.rbtnNaive.Text = "Naive";
            this.rbtnNaive.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnNaive);
            this.groupBox1.Controls.Add(this.rbtnBresenham);
            this.groupBox1.Controls.Add(this.rbtnDDA);
            this.groupBox1.Controls.Add(this.rbtnNGon);
            this.groupBox1.Controls.Add(this.rbtnBintang);
            this.groupBox1.Controls.Add(this.rbtnElips);
            this.groupBox1.Controls.Add(this.rbtnLingkaran);
            this.groupBox1.Location = new System.Drawing.Point(609, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 184);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bentuk";
            // 
            // rbtnBresenham
            // 
            this.rbtnBresenham.AutoSize = true;
            this.rbtnBresenham.Location = new System.Drawing.Point(12, 62);
            this.rbtnBresenham.Name = "rbtnBresenham";
            this.rbtnBresenham.Size = new System.Drawing.Size(80, 16);
            this.rbtnBresenham.TabIndex = 30;
            this.rbtnBresenham.TabStop = true;
            this.rbtnBresenham.Text = "Bresenham";
            this.rbtnBresenham.UseVisualStyleBackColor = true;
            // 
            // rbtnDDA
            // 
            this.rbtnDDA.AutoSize = true;
            this.rbtnDDA.Location = new System.Drawing.Point(12, 40);
            this.rbtnDDA.Name = "rbtnDDA";
            this.rbtnDDA.Size = new System.Drawing.Size(47, 16);
            this.rbtnDDA.TabIndex = 29;
            this.rbtnDDA.TabStop = true;
            this.rbtnDDA.Text = "DDA";
            this.rbtnDDA.UseVisualStyleBackColor = true;
            // 
            // rbtnNGon
            // 
            this.rbtnNGon.AutoSize = true;
            this.rbtnNGon.Location = new System.Drawing.Point(12, 159);
            this.rbtnNGon.Name = "rbtnNGon";
            this.rbtnNGon.Size = new System.Drawing.Size(51, 16);
            this.rbtnNGon.TabIndex = 33;
            this.rbtnNGon.TabStop = true;
            this.rbtnNGon.Text = "NGon";
            this.rbtnNGon.UseVisualStyleBackColor = true;
            // 
            // rbtnBintang
            // 
            this.rbtnBintang.AutoSize = true;
            this.rbtnBintang.Location = new System.Drawing.Point(12, 137);
            this.rbtnBintang.Name = "rbtnBintang";
            this.rbtnBintang.Size = new System.Drawing.Size(62, 16);
            this.rbtnBintang.TabIndex = 32;
            this.rbtnBintang.TabStop = true;
            this.rbtnBintang.Text = "Bintang";
            this.rbtnBintang.UseVisualStyleBackColor = true;
            // 
            // rbtnElips
            // 
            this.rbtnElips.AutoSize = true;
            this.rbtnElips.Location = new System.Drawing.Point(12, 115);
            this.rbtnElips.Name = "rbtnElips";
            this.rbtnElips.Size = new System.Drawing.Size(48, 16);
            this.rbtnElips.TabIndex = 29;
            this.rbtnElips.TabStop = true;
            this.rbtnElips.Text = "Elips";
            this.rbtnElips.UseVisualStyleBackColor = true;
            // 
            // rbtnLingkaran
            // 
            this.rbtnLingkaran.AutoSize = true;
            this.rbtnLingkaran.Location = new System.Drawing.Point(12, 93);
            this.rbtnLingkaran.Name = "rbtnLingkaran";
            this.rbtnLingkaran.Size = new System.Drawing.Size(72, 16);
            this.rbtnLingkaran.TabIndex = 28;
            this.rbtnLingkaran.TabStop = true;
            this.rbtnLingkaran.Text = "Lingkaran";
            this.rbtnLingkaran.UseVisualStyleBackColor = true;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(692, 251);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(61, 19);
            this.txtN.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(694, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 12);
            this.label13.TabIndex = 31;
            this.label13.Text = "Jumlah N";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(620, 249);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(61, 23);
            this.btnColor.TabIndex = 32;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(631, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 12);
            this.label7.TabIndex = 33;
            this.label7.Text = "Warna";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReflectYminX);
            this.groupBox3.Controls.Add(this.btnReflectYX);
            this.groupBox3.Controls.Add(this.btnReflectY);
            this.groupBox3.Controls.Add(this.txtRotate);
            this.groupBox3.Controls.Add(this.btnReflectX);
            this.groupBox3.Controls.Add(this.btnRotate);
            this.groupBox3.Controls.Add(this.btnScale);
            this.groupBox3.Controls.Add(this.btnTranslate);
            this.groupBox3.Controls.Add(this.txtScale);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtDeltaY);
            this.groupBox3.Controls.Add(this.txtDeltaX);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(247, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 82);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transformation";
            // 
            // btnReflectYminX
            // 
            this.btnReflectYminX.Location = new System.Drawing.Point(411, 53);
            this.btnReflectYminX.Name = "btnReflectYminX";
            this.btnReflectYminX.Size = new System.Drawing.Size(80, 23);
            this.btnReflectYminX.TabIndex = 47;
            this.btnReflectYminX.Text = "Reflect y=-x";
            this.btnReflectYminX.UseVisualStyleBackColor = true;
            this.btnReflectYminX.Click += new System.EventHandler(this.btnReflectYminX_Click);
            // 
            // btnReflectYX
            // 
            this.btnReflectYX.Location = new System.Drawing.Point(330, 53);
            this.btnReflectYX.Name = "btnReflectYX";
            this.btnReflectYX.Size = new System.Drawing.Size(75, 23);
            this.btnReflectYX.TabIndex = 46;
            this.btnReflectYX.Text = "Reflect y=x";
            this.btnReflectYX.UseVisualStyleBackColor = true;
            this.btnReflectYX.Click += new System.EventHandler(this.btnReflectYX_Click);
            // 
            // btnReflectY
            // 
            this.btnReflectY.Location = new System.Drawing.Point(411, 18);
            this.btnReflectY.Name = "btnReflectY";
            this.btnReflectY.Size = new System.Drawing.Size(80, 23);
            this.btnReflectY.TabIndex = 45;
            this.btnReflectY.Text = "Reflect y";
            this.btnReflectY.UseVisualStyleBackColor = true;
            this.btnReflectY.Click += new System.EventHandler(this.btnReflectY_Click);
            // 
            // txtRotate
            // 
            this.txtRotate.Location = new System.Drawing.Point(269, 57);
            this.txtRotate.Name = "txtRotate";
            this.txtRotate.Size = new System.Drawing.Size(33, 19);
            this.txtRotate.TabIndex = 44;
            // 
            // btnReflectX
            // 
            this.btnReflectX.Location = new System.Drawing.Point(330, 18);
            this.btnReflectX.Name = "btnReflectX";
            this.btnReflectX.Size = new System.Drawing.Size(75, 23);
            this.btnReflectX.TabIndex = 43;
            this.btnReflectX.Text = "Reflect x";
            this.btnReflectX.UseVisualStyleBackColor = true;
            this.btnReflectX.Click += new System.EventHandler(this.btnReflectX_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(245, 18);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(75, 23);
            this.btnRotate.TabIndex = 42;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnScale
            // 
            this.btnScale.Location = new System.Drawing.Point(144, 18);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(75, 23);
            this.btnScale.TabIndex = 41;
            this.btnScale.Text = "Scale";
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(37, 18);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 40;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // txtScale
            // 
            this.txtScale.Location = new System.Drawing.Point(159, 57);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(33, 19);
            this.txtScale.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 38;
            this.label10.Text = "x";
            // 
            // txtDeltaY
            // 
            this.txtDeltaY.Location = new System.Drawing.Point(88, 57);
            this.txtDeltaY.Name = "txtDeltaY";
            this.txtDeltaY.Size = new System.Drawing.Size(33, 19);
            this.txtDeltaY.TabIndex = 37;
            // 
            // txtDeltaX
            // 
            this.txtDeltaX.Location = new System.Drawing.Point(28, 57);
            this.txtDeltaX.Name = "txtDeltaX";
            this.txtDeltaX.Size = new System.Drawing.Size(33, 19);
            this.txtDeltaX.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 12);
            this.label8.TabIndex = 35;
            this.label8.Text = "ΔY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 12);
            this.label9.TabIndex = 34;
            this.label9.Text = "ΔX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 383);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtYB);
            this.Controls.Add(this.txtXB);
            this.Controls.Add(this.txtYA);
            this.Controls.Add(this.txtXA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Mini Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtXA;
        private System.Windows.Forms.TextBox txtYA;
        private System.Windows.Forms.TextBox txtXB;
        private System.Windows.Forms.TextBox txtYB;
        private System.Windows.Forms.RadioButton rbtnNaive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnBresenham;
        private System.Windows.Forms.RadioButton rbtnDDA;
        private System.Windows.Forms.RadioButton rbtnElips;
        private System.Windows.Forms.RadioButton rbtnLingkaran;
        private System.Windows.Forms.RadioButton rbtnBintang;
        private System.Windows.Forms.RadioButton rbtnNGon;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtScale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDeltaY;
        private System.Windows.Forms.TextBox txtDeltaX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReflectX;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnScale;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.TextBox txtRotate;
        private System.Windows.Forms.Button btnReflectYminX;
        private System.Windows.Forms.Button btnReflectYX;
        private System.Windows.Forms.Button btnReflectY;
    }
}

