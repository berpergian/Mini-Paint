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
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.txtYTambah = new System.Windows.Forms.TextBox();
            this.txtXTambah = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtGradien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtJari2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rbtnNaive = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnBintang = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnBresenham = new System.Windows.Forms.RadioButton();
            this.rbtnDDA = new System.Windows.Forms.RadioButton();
            this.rbtnElips = new System.Windows.Forms.RadioButton();
            this.rbtnLingkaran = new System.Windows.Forms.RadioButton();
            this.rbtnNGon = new System.Windows.Forms.RadioButton();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(66, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Y";
            // 
            // txtXA
            // 
            this.txtXA.Location = new System.Drawing.Point(28, 312);
            this.txtXA.Name = "txtXA";
            this.txtXA.Size = new System.Drawing.Size(33, 19);
            this.txtXA.TabIndex = 8;
            // 
            // txtYA
            // 
            this.txtYA.Location = new System.Drawing.Point(85, 312);
            this.txtYA.Name = "txtYA";
            this.txtYA.Size = new System.Drawing.Size(33, 19);
            this.txtYA.TabIndex = 9;
            // 
            // txtXB
            // 
            this.txtXB.Location = new System.Drawing.Point(151, 312);
            this.txtXB.Name = "txtXB";
            this.txtXB.Size = new System.Drawing.Size(33, 19);
            this.txtXB.TabIndex = 10;
            // 
            // txtYB
            // 
            this.txtYB.Location = new System.Drawing.Point(208, 312);
            this.txtYB.Name = "txtYB";
            this.txtYB.Size = new System.Drawing.Size(33, 19);
            this.txtYB.TabIndex = 11;
            // 
            // txtSteps
            // 
            this.txtSteps.Location = new System.Drawing.Point(396, 312);
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.ReadOnly = true;
            this.txtSteps.Size = new System.Drawing.Size(33, 19);
            this.txtSteps.TabIndex = 12;
            // 
            // txtYTambah
            // 
            this.txtYTambah.Location = new System.Drawing.Point(332, 312);
            this.txtYTambah.Name = "txtYTambah";
            this.txtYTambah.ReadOnly = true;
            this.txtYTambah.Size = new System.Drawing.Size(33, 19);
            this.txtYTambah.TabIndex = 13;
            // 
            // txtXTambah
            // 
            this.txtXTambah.Location = new System.Drawing.Point(271, 312);
            this.txtXTambah.Name = "txtXTambah";
            this.txtXTambah.ReadOnly = true;
            this.txtXTambah.Size = new System.Drawing.Size(33, 19);
            this.txtXTambah.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "X Tambah";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "Y Tambah";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(395, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "Steps";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(513, 312);
            this.txtC.Name = "txtC";
            this.txtC.ReadOnly = true;
            this.txtC.Size = new System.Drawing.Size(33, 19);
            this.txtC.TabIndex = 19;
            // 
            // txtGradien
            // 
            this.txtGradien.Location = new System.Drawing.Point(449, 312);
            this.txtGradien.Name = "txtGradien";
            this.txtGradien.ReadOnly = true;
            this.txtGradien.Size = new System.Drawing.Size(44, 19);
            this.txtGradien.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(521, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(449, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "Gradien";
            // 
            // txtJari2
            // 
            this.txtJari2.Location = new System.Drawing.Point(570, 312);
            this.txtJari2.Name = "txtJari2";
            this.txtJari2.ReadOnly = true;
            this.txtJari2.Size = new System.Drawing.Size(33, 19);
            this.txtJari2.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(572, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "Jari2";
            // 
            // rbtnNaive
            // 
            this.rbtnNaive.AutoSize = true;
            this.rbtnNaive.Location = new System.Drawing.Point(6, 18);
            this.rbtnNaive.Name = "rbtnNaive";
            this.rbtnNaive.Size = new System.Drawing.Size(52, 16);
            this.rbtnNaive.TabIndex = 28;
            this.rbtnNaive.TabStop = true;
            this.rbtnNaive.Text = "Naive";
            this.rbtnNaive.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnNGon);
            this.groupBox1.Controls.Add(this.rbtnBintang);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.rbtnElips);
            this.groupBox1.Controls.Add(this.rbtnLingkaran);
            this.groupBox1.Location = new System.Drawing.Point(609, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 198);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bentuk";
            // 
            // rbtnBintang
            // 
            this.rbtnBintang.AutoSize = true;
            this.rbtnBintang.Location = new System.Drawing.Point(12, 150);
            this.rbtnBintang.Name = "rbtnBintang";
            this.rbtnBintang.Size = new System.Drawing.Size(62, 16);
            this.rbtnBintang.TabIndex = 32;
            this.rbtnBintang.TabStop = true;
            this.rbtnBintang.Text = "Bintang";
            this.rbtnBintang.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnNaive);
            this.groupBox2.Controls.Add(this.rbtnBresenham);
            this.groupBox2.Controls.Add(this.rbtnDDA);
            this.groupBox2.Location = new System.Drawing.Point(6, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 82);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Line";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbtnBresenham
            // 
            this.rbtnBresenham.AutoSize = true;
            this.rbtnBresenham.Location = new System.Drawing.Point(6, 62);
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
            this.rbtnDDA.Location = new System.Drawing.Point(6, 40);
            this.rbtnDDA.Name = "rbtnDDA";
            this.rbtnDDA.Size = new System.Drawing.Size(47, 16);
            this.rbtnDDA.TabIndex = 29;
            this.rbtnDDA.TabStop = true;
            this.rbtnDDA.Text = "DDA";
            this.rbtnDDA.UseVisualStyleBackColor = true;
            // 
            // rbtnElips
            // 
            this.rbtnElips.AutoSize = true;
            this.rbtnElips.Location = new System.Drawing.Point(12, 128);
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
            this.rbtnLingkaran.Location = new System.Drawing.Point(12, 106);
            this.rbtnLingkaran.Name = "rbtnLingkaran";
            this.rbtnLingkaran.Size = new System.Drawing.Size(72, 16);
            this.rbtnLingkaran.TabIndex = 28;
            this.rbtnLingkaran.TabStop = true;
            this.rbtnLingkaran.Text = "Lingkaran";
            this.rbtnLingkaran.UseVisualStyleBackColor = true;
            // 
            // rbtnNGon
            // 
            this.rbtnNGon.AutoSize = true;
            this.rbtnNGon.Location = new System.Drawing.Point(12, 172);
            this.rbtnNGon.Name = "rbtnNGon";
            this.rbtnNGon.Size = new System.Drawing.Size(51, 16);
            this.rbtnNGon.TabIndex = 33;
            this.rbtnNGon.TabStop = true;
            this.rbtnNGon.Text = "NGon";
            this.rbtnNGon.UseVisualStyleBackColor = true;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(668, 312);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(61, 19);
            this.txtN.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(670, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 12);
            this.label13.TabIndex = 31;
            this.label13.Text = "Jumlah N";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 343);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtJari2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtGradien);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtXTambah);
            this.Controls.Add(this.txtYTambah);
            this.Controls.Add(this.txtSteps);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox txtSteps;
        private System.Windows.Forms.TextBox txtYTambah;
        private System.Windows.Forms.TextBox txtXTambah;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtGradien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtJari2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbtnNaive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnBresenham;
        private System.Windows.Forms.RadioButton rbtnDDA;
        private System.Windows.Forms.RadioButton rbtnElips;
        private System.Windows.Forms.RadioButton rbtnLingkaran;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnBintang;
        private System.Windows.Forms.RadioButton rbtnNGon;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label13;
    }
}

