namespace BilgiYarismasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnB = new Button();
            btnD = new Button();
            btnC = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblSoruNo = new Label();
            lblDogru = new Label();
            lblYanlis = new Label();
            btnSonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(637, 268);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.Location = new Point(12, 305);
            btnA.Name = "btnA";
            btnA.Size = new Size(282, 41);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(364, 305);
            btnB.Name = "btnB";
            btnB.Size = new Size(285, 41);
            btnB.TabIndex = 2;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(364, 370);
            btnD.Name = "btnD";
            btnD.Size = new Size(285, 41);
            btnD.TabIndex = 3;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(12, 370);
            btnC.Name = "btnC";
            btnC.Size = new Size(282, 41);
            btnC.TabIndex = 4;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(703, 29);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 5;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(722, 84);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 6;
            label2.Text = "Dogru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(733, 149);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 7;
            label3.Text = "Yanlış";
            // 
            // lblSoruNo
            // 
            lblSoruNo.AutoSize = true;
            lblSoruNo.Location = new Point(823, 29);
            lblSoruNo.Name = "lblSoruNo";
            lblSoruNo.Size = new Size(24, 28);
            lblSoruNo.TabIndex = 8;
            lblSoruNo.Text = "0";
            // 
            // lblDogru
            // 
            lblDogru.AutoSize = true;
            lblDogru.Location = new Point(823, 84);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(24, 28);
            lblDogru.TabIndex = 9;
            lblDogru.Text = "0";
            // 
            // lblYanlis
            // 
            lblYanlis.AutoSize = true;
            lblYanlis.Location = new Point(823, 149);
            lblYanlis.Name = "lblYanlis";
            lblYanlis.Size = new Size(24, 28);
            lblYanlis.TabIndex = 10;
            lblYanlis.Text = "0";
            // 
            // btnSonraki
            // 
            btnSonraki.Location = new Point(703, 212);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(191, 41);
            btnSonraki.TabIndex = 11;
            btnSonraki.Text = "Sonraki";
            btnSonraki.UseVisualStyleBackColor = true;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(685, 304);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(823, 304);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(108, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(669, 423);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(771, 423);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(961, 445);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSonraki);
            Controls.Add(lblYanlis);
            Controls.Add(lblDogru);
            Controls.Add(lblSoruNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnC);
            Controls.Add(btnD);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnB;
        private Button btnD;
        private Button btnC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblSoruNo;
        private Label lblDogru;
        private Label lblYanlis;
        private Button btnSonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}
