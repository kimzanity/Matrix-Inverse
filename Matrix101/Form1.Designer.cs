namespace Matrix101
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.BunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.BunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.BunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.BunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.about1 = new Matrix101.about();
            this.three1 = new Matrix101.three();
            this.two1 = new Matrix101.two();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.panel4.Controls.Add(this.Label1);
            this.panel4.Controls.Add(this.PictureBox1);
            this.panel4.Controls.Add(this.BunifuImageButton2);
            this.panel4.Controls.Add(this.BunifuImageButton1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 40);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label1.Location = new System.Drawing.Point(43, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(94, 17);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Inverse Matrix";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(6, 11);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(20, 20);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            // 
            // BunifuImageButton2
            // 
            this.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.BunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("BunifuImageButton2.Image")));
            this.BunifuImageButton2.ImageActive = null;
            this.BunifuImageButton2.Location = new System.Drawing.Point(652, 14);
            this.BunifuImageButton2.Name = "BunifuImageButton2";
            this.BunifuImageButton2.Size = new System.Drawing.Size(15, 15);
            this.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BunifuImageButton2.TabIndex = 4;
            this.BunifuImageButton2.TabStop = false;
            this.BunifuImageButton2.Zoom = 15;
            this.BunifuImageButton2.Click += new System.EventHandler(this.BunifuImageButton2_Click);
            // 
            // BunifuImageButton1
            // 
            this.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.BunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("BunifuImageButton1.Image")));
            this.BunifuImageButton1.ImageActive = null;
            this.BunifuImageButton1.Location = new System.Drawing.Point(673, 10);
            this.BunifuImageButton1.Name = "BunifuImageButton1";
            this.BunifuImageButton1.Size = new System.Drawing.Size(15, 15);
            this.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BunifuImageButton1.TabIndex = 3;
            this.BunifuImageButton1.TabStop = false;
            this.BunifuImageButton1.Zoom = 15;
            this.BunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.about1);
            this.panel2.Controls.Add(this.three1);
            this.panel2.Controls.Add(this.two1);
            this.panel2.Location = new System.Drawing.Point(12, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 420);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuImageButton5);
            this.panel3.Controls.Add(this.BunifuImageButton4);
            this.panel3.Controls.Add(this.BunifuFlatButton2);
            this.panel3.Controls.Add(this.BunifuImageButton3);
            this.panel3.Controls.Add(this.BunifuFlatButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 64);
            this.panel3.TabIndex = 2;
            // 
            // BunifuImageButton4
            // 
            this.BunifuImageButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(156)))), ((int)(((byte)(219)))));
            this.BunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("BunifuImageButton4.Image")));
            this.BunifuImageButton4.ImageActive = null;
            this.BunifuImageButton4.Location = new System.Drawing.Point(162, 45);
            this.BunifuImageButton4.Name = "BunifuImageButton4";
            this.BunifuImageButton4.Size = new System.Drawing.Size(136, 5);
            this.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BunifuImageButton4.TabIndex = 8;
            this.BunifuImageButton4.TabStop = false;
            this.BunifuImageButton4.Zoom = 10;
            // 
            // BunifuFlatButton2
            // 
            this.BunifuFlatButton2.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuFlatButton2.BorderRadius = 0;
            this.BunifuFlatButton2.ButtonText = "3x3 Matrix";
            this.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.BunifuFlatButton2.Iconimage = null;
            this.BunifuFlatButton2.Iconimage_right = null;
            this.BunifuFlatButton2.Iconimage_right_Selected = null;
            this.BunifuFlatButton2.Iconimage_Selected = null;
            this.BunifuFlatButton2.IconMarginLeft = 0;
            this.BunifuFlatButton2.IconMarginRight = 0;
            this.BunifuFlatButton2.IconRightVisible = true;
            this.BunifuFlatButton2.IconRightZoom = 0D;
            this.BunifuFlatButton2.IconVisible = true;
            this.BunifuFlatButton2.IconZoom = 90D;
            this.BunifuFlatButton2.IsTab = false;
            this.BunifuFlatButton2.Location = new System.Drawing.Point(162, 15);
            this.BunifuFlatButton2.Name = "BunifuFlatButton2";
            this.BunifuFlatButton2.Normalcolor = System.Drawing.Color.Empty;
            this.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.BunifuFlatButton2.selected = false;
            this.BunifuFlatButton2.Size = new System.Drawing.Size(136, 24);
            this.BunifuFlatButton2.TabIndex = 7;
            this.BunifuFlatButton2.Text = "3x3 Matrix";
            this.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // BunifuImageButton3
            // 
            this.BunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(156)))), ((int)(((byte)(219)))));
            this.BunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("BunifuImageButton3.Image")));
            this.BunifuImageButton3.ImageActive = null;
            this.BunifuImageButton3.Location = new System.Drawing.Point(20, 45);
            this.BunifuImageButton3.Name = "BunifuImageButton3";
            this.BunifuImageButton3.Size = new System.Drawing.Size(136, 5);
            this.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BunifuImageButton3.TabIndex = 6;
            this.BunifuImageButton3.TabStop = false;
            this.BunifuImageButton3.Zoom = 10;
            // 
            // BunifuFlatButton1
            // 
            this.BunifuFlatButton1.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuFlatButton1.BorderRadius = 0;
            this.BunifuFlatButton1.ButtonText = "2x2 Matrix";
            this.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.BunifuFlatButton1.Iconimage = null;
            this.BunifuFlatButton1.Iconimage_right = null;
            this.BunifuFlatButton1.Iconimage_right_Selected = null;
            this.BunifuFlatButton1.Iconimage_Selected = null;
            this.BunifuFlatButton1.IconMarginLeft = 0;
            this.BunifuFlatButton1.IconMarginRight = 0;
            this.BunifuFlatButton1.IconRightVisible = true;
            this.BunifuFlatButton1.IconRightZoom = 0D;
            this.BunifuFlatButton1.IconVisible = true;
            this.BunifuFlatButton1.IconZoom = 90D;
            this.BunifuFlatButton1.IsTab = false;
            this.BunifuFlatButton1.Location = new System.Drawing.Point(20, 15);
            this.BunifuFlatButton1.Name = "BunifuFlatButton1";
            this.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Empty;
            this.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.BunifuFlatButton1.selected = false;
            this.BunifuFlatButton1.Size = new System.Drawing.Size(136, 24);
            this.BunifuFlatButton1.TabIndex = 5;
            this.BunifuFlatButton1.Text = "2x2 Matrix";
            this.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel4;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(647, 6);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(50, 50);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 9;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 15;
            this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // about1
            // 
            this.about1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.about1.Location = new System.Drawing.Point(0, 0);
            this.about1.Name = "about1";
            this.about1.Size = new System.Drawing.Size(676, 420);
            this.about1.TabIndex = 2;
            // 
            // three1
            // 
            this.three1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.three1.Location = new System.Drawing.Point(0, 0);
            this.three1.Name = "three1";
            this.three1.Size = new System.Drawing.Size(676, 420);
            this.three1.TabIndex = 1;
            this.three1.Load += new System.EventHandler(this.three1_Load);
            // 
            // two1
            // 
            this.two1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.two1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.two1.Location = new System.Drawing.Point(0, 0);
            this.two1.Name = "two1";
            this.two1.Size = new System.Drawing.Size(676, 420);
            this.two1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private two two1;
        private System.Windows.Forms.Panel panel3;
        internal Bunifu.Framework.UI.BunifuImageButton BunifuImageButton4;
        internal Bunifu.Framework.UI.BunifuFlatButton BunifuFlatButton2;
        internal Bunifu.Framework.UI.BunifuImageButton BunifuImageButton3;
        internal Bunifu.Framework.UI.BunifuFlatButton BunifuFlatButton1;
        private three three1;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal Bunifu.Framework.UI.BunifuImageButton BunifuImageButton2;
        internal Bunifu.Framework.UI.BunifuImageButton BunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private about about1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
    }
}

