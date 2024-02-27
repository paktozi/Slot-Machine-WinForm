namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            run = new Button();
            timer = new System.Windows.Forms.Timer(components);
            pictureBoxJackpot = new PictureBox();
            richTextBoxResult = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJackpot).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cherry;
            pictureBox1.Location = new Point(86, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 269);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.seven;
            pictureBox2.Location = new Point(330, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(243, 269);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.lime;
            pictureBox3.Location = new Point(574, 88);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(243, 269);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // run
            // 
            run.BackColor = Color.LimeGreen;
            run.Location = new Point(877, 88);
            run.Name = "run";
            run.Size = new Size(130, 103);
            run.TabIndex = 6;
            run.Text = "Spin";
            run.UseVisualStyleBackColor = false;
            run.Click += button1_Click;
            // 
            // pictureBoxJackpot
            // 
            pictureBoxJackpot.BackColor = Color.Transparent;
            pictureBoxJackpot.Image = (Image)resources.GetObject("pictureBoxJackpot.Image");
            pictureBoxJackpot.Location = new Point(2, 3);
            pictureBoxJackpot.Name = "pictureBoxJackpot";
            pictureBoxJackpot.Size = new Size(874, 468);
            pictureBoxJackpot.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxJackpot.TabIndex = 7;
            pictureBoxJackpot.TabStop = false;
            pictureBoxJackpot.Visible = false;
            // 
            // richTextBoxResult
            // 
            richTextBoxResult.BackColor = Color.WhiteSmoke;
            richTextBoxResult.BorderStyle = BorderStyle.None;
            richTextBoxResult.Font = new Font("DS-Digital", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBoxResult.Location = new Point(877, 197);
            richTextBoxResult.Name = "richTextBoxResult";
            richTextBoxResult.ReadOnly = true;
            richTextBoxResult.Size = new Size(130, 84);
            richTextBoxResult.TabIndex = 8;
            richTextBoxResult.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1040, 473);
            Controls.Add(pictureBoxJackpot);
            Controls.Add(richTextBoxResult);
            Controls.Add(run);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Slot Machine by Ivo Vaklinov";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJackpot).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button run;
        private System.Windows.Forms.Timer timer;
        private PictureBox pictureBoxJackpot;
        private RichTextBox richTextBoxResult;
    }
}
