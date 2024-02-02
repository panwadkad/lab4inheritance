namespace lab4inheritance
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
            lbNAME = new Label();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btLOAD = new Button();
            btLOAD3 = new Button();
            btLOAD2 = new Button();
            button3 = new Button();
            btLOAD4 = new Button();
            btLOAD5 = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbNAME
            // 
            lbNAME.AutoSize = true;
            lbNAME.Location = new Point(233, 29);
            lbNAME.Name = "lbNAME";
            lbNAME.Size = new Size(50, 20);
            lbNAME.TabIndex = 0;
            lbNAME.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(132, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btLOAD
            // 
            btLOAD.BackColor = Color.Yellow;
            btLOAD.Location = new Point(99, 256);
            btLOAD.Name = "btLOAD";
            btLOAD.Size = new Size(153, 29);
            btLOAD.TabIndex = 3;
            btLOAD.Text = "LOAD POKEMON";
            btLOAD.UseVisualStyleBackColor = false;
            btLOAD.Click += btLOAD_Click;
            // 
            // btLOAD3
            // 
            btLOAD3.BackColor = Color.DarkGoldenrod;
            btLOAD3.Location = new Point(99, 355);
            btLOAD3.Name = "btLOAD3";
            btLOAD3.Size = new Size(153, 29);
            btLOAD3.TabIndex = 4;
            btLOAD3.Text = "LOAD POKEMON";
            btLOAD3.UseVisualStyleBackColor = false;
            btLOAD3.Click += btLOAD3_Click;
            // 
            // btLOAD2
            // 
            btLOAD2.BackColor = Color.Coral;
            btLOAD2.Location = new Point(99, 306);
            btLOAD2.Name = "btLOAD2";
            btLOAD2.Size = new Size(153, 29);
            btLOAD2.TabIndex = 5;
            btLOAD2.Text = "LOAD POKEMON";
            btLOAD2.UseVisualStyleBackColor = false;
            btLOAD2.Click += btLOAD2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LimeGreen;
            button3.Location = new Point(280, 256);
            button3.Name = "button3";
            button3.Size = new Size(153, 29);
            button3.TabIndex = 6;
            button3.Text = "LOAD POKEMON";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btLOAD4
            // 
            btLOAD4.BackColor = Color.Cyan;
            btLOAD4.Location = new Point(280, 306);
            btLOAD4.Name = "btLOAD4";
            btLOAD4.Size = new Size(153, 29);
            btLOAD4.TabIndex = 7;
            btLOAD4.Text = "LOAD POKEMON";
            btLOAD4.UseVisualStyleBackColor = false;
            btLOAD4.Click += btLOAD4_Click;
            // 
            // btLOAD5
            // 
            btLOAD5.BackColor = Color.HotPink;
            btLOAD5.Location = new Point(280, 355);
            btLOAD5.Name = "btLOAD5";
            btLOAD5.Size = new Size(153, 29);
            btLOAD5.TabIndex = 8;
            btLOAD5.Text = "LOAD POKEMON";
            btLOAD5.UseVisualStyleBackColor = false;
            btLOAD5.Click += btLOAD5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2024_02_02_170052;
            pictureBox2.Location = new Point(804, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(443, 359);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(804, 29);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 9;
            label1.Text = "ENAMY";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 519);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(btLOAD5);
            Controls.Add(btLOAD4);
            Controls.Add(button3);
            Controls.Add(btLOAD2);
            Controls.Add(btLOAD3);
            Controls.Add(btLOAD);
            Controls.Add(pictureBox1);
            Controls.Add(lbNAME);
            Name = "Form1";
            Text = "ENAMY";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNAME;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button btLOAD;
        private Button btLOAD3;
        private Button btLOAD2;
        private Button button3;
        private Button btLOAD4;
        private Button btLOAD5;
        private PictureBox pictureBox2;
        private Label label1;
    }
}
