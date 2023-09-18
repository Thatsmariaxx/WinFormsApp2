namespace WinFormsApp2
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            iusername = new TextBox();
            ipassword = new TextBox();
            comboBox1 = new ComboBox();
            ilogin = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(307, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 205);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 1;
            label1.Text = "Department:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 264);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 324);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // iusername
            // 
            iusername.Location = new Point(343, 264);
            iusername.Name = "iusername";
            iusername.Size = new Size(150, 31);
            iusername.TabIndex = 4;
            // 
            // ipassword
            // 
            ipassword.Location = new Point(344, 321);
            ipassword.Name = "ipassword";
            ipassword.Size = new Size(150, 31);
            ipassword.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "SHS", "College" });
            comboBox1.Location = new Point(343, 204);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ilogin
            // 
            ilogin.Location = new Point(348, 372);
            ilogin.Name = "ilogin";
            ilogin.Size = new Size(112, 34);
            ilogin.TabIndex = 7;
            ilogin.Text = "Log In";
            ilogin.UseVisualStyleBackColor = true;
            ilogin.Click += ilogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.ForeColor = Color.Maroon;
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(50, 451);
            panel1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(ilogin);
            Controls.Add(comboBox1);
            Controls.Add(ipassword);
            Controls.Add(iusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox iusername;
        private TextBox ipassword;
        private ComboBox comboBox1;
        private Button ilogin;
        private Panel panel1;
    }
}