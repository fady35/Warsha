namespace WindowsFormsApp1
{
    partial class LOGINWHARcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGINWHARcs));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labusername = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labpassword = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.wARSHA1TableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.WARSHA1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(132, 633);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(194, 20);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an Account";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(49, 39);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 1);
            this.panel3.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(49, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "WARSHA_NAME";
            // 
            // labusername
            // 
            this.labusername.AutoSize = true;
            this.labusername.Font = new System.Drawing.Font("Lama Sans Medium", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labusername.Location = new System.Drawing.Point(48, 50);
            this.labusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labusername.Name = "labusername";
            this.labusername.Size = new System.Drawing.Size(115, 15);
            this.labusername.TabIndex = 1;
            this.labusername.Text = "Invalid User Name";
            this.labusername.Visible = false;
            this.labusername.Click += new System.EventHandler(this.labusername_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 7);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(49, 36);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 1);
            this.panel4.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(49, 4);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(367, 21);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Password";
            // 
            // labpassword
            // 
            this.labpassword.AutoSize = true;
            this.labpassword.Font = new System.Drawing.Font("Lama Sans Medium", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labpassword.Location = new System.Drawing.Point(52, 48);
            this.labpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labpassword.Name = "labpassword";
            this.labpassword.Size = new System.Drawing.Size(108, 15);
            this.labpassword.TabIndex = 5;
            this.labpassword.Text = "Invalid Password";
            this.labpassword.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.pnlLogin.Controls.Add(this.linkLabel1);
            this.pnlLogin.Controls.Add(this.panel10);
            this.pnlLogin.Controls.Add(this.pictureBox4);
            this.pnlLogin.Controls.Add(this.button1);
            this.pnlLogin.Controls.Add(this.panel2);
            this.pnlLogin.Controls.Add(this.panel1);
            this.pnlLogin.Controls.Add(this.pictureBox1);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLogin.Location = new System.Drawing.Point(858, 0);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(477, 834);
            this.pnlLogin.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.bunifuImageButton6);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(477, 53);
            this.panel10.TabIndex = 14;
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.bunifuImageButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(427, 17);
            this.bunifuImageButton6.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(27, 25);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 13;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(179, 135);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(107, 107);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(31, 541);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(416, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "Login ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.labpassword);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(31, 448);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 70);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.labusername);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Location = new System.Drawing.Point(34, 344);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 70);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 832);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(862, 834);
            this.panel5.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(858, 834);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this.bunifuImageButton6;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 22;
            this.bunifuElipse3.TargetControl = this;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 50;
            this.bunifuElipse5.TargetControl = this.button1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wARSHA1TableAdapter
            // 
            this.wARSHA1TableAdapter.ClearBeforeFill = true;
            // 
            // LOGINWHARcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 834);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGINWHARcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGINWHARcs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labusername;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labpassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel panel10;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.WARSHA1TableAdapter wARSHA1TableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}