
namespace NGE_ANIMA_GAME_TOOLS
{
    partial class bmpviewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bmpviewer));
            this.bmpfiles = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.compilarbutton = new System.Windows.Forms.Button();
            this.extraerbutton = new System.Windows.Forms.Button();
            this.filename_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxImages = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Filedialogbmp = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogbmp = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // bmpfiles
            // 
            this.bmpfiles.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.bmpfiles.ImageSize = new System.Drawing.Size(16, 16);
            this.bmpfiles.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.compilarbutton);
            this.groupBox1.Controls.Add(this.extraerbutton);
            this.groupBox1.Controls.Add(this.filename_label);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBoxImages);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(542, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagenes";
            // 
            // compilarbutton
            // 
            this.compilarbutton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compilarbutton.ForeColor = System.Drawing.Color.Black;
            this.compilarbutton.Location = new System.Drawing.Point(3, 62);
            this.compilarbutton.Name = "compilarbutton";
            this.compilarbutton.Size = new System.Drawing.Size(114, 23);
            this.compilarbutton.TabIndex = 11;
            this.compilarbutton.Text = "Compilar";
            this.compilarbutton.UseVisualStyleBackColor = true;
            this.compilarbutton.Click += new System.EventHandler(this.compilarbutton_Click);
            // 
            // extraerbutton
            // 
            this.extraerbutton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraerbutton.ForeColor = System.Drawing.Color.Black;
            this.extraerbutton.Location = new System.Drawing.Point(3, 37);
            this.extraerbutton.Name = "extraerbutton";
            this.extraerbutton.Size = new System.Drawing.Size(114, 23);
            this.extraerbutton.TabIndex = 10;
            this.extraerbutton.Text = "Extraer";
            this.extraerbutton.UseVisualStyleBackColor = true;
            this.extraerbutton.Click += new System.EventHandler(this.extraerbutton_Click);
            // 
            // filename_label
            // 
            this.filename_label.AutoSize = true;
            this.filename_label.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filename_label.Location = new System.Drawing.Point(85, 21);
            this.filename_label.Name = "filename_label";
            this.filename_label.Size = new System.Drawing.Size(0, 13);
            this.filename_label.TabIndex = 9;
            this.filename_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reemplazar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxImages
            // 
            this.listBoxImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(81)))), ((int)(((byte)(180)))));
            this.listBoxImages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxImages.ForeColor = System.Drawing.Color.White;
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.Location = new System.Drawing.Point(3, 89);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.Size = new System.Drawing.Size(114, 199);
            this.listBoxImages.TabIndex = 0;
            this.listBoxImages.SelectedIndexChanged += new System.EventHandler(this.listBoxImages_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(7, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 437);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visualizador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NGE_ANIMA_GAME_TOOLS.Properties.Resources.eva_black;
            this.pictureBox1.Location = new System.Drawing.Point(6, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 416);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::NGE_ANIMA_GAME_TOOLS.Properties.Resources.eva__white;
            this.pictureBox4.Location = new System.Drawing.Point(542, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(118, 132);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // Filedialogbmp
            // 
            this.Filedialogbmp.DefaultExt = "bmp";
            this.Filedialogbmp.FileName = "BMP";
            this.Filedialogbmp.Filter = "\"bmp files\" (*.bmp)|*.bmp";
            this.Filedialogbmp.InitialDirectory = "C:\\Program Files (x86)\\GAINAX\\IRONMAIDEN2";
            this.Filedialogbmp.Title = "Selecciona una imagen BMP";
            // 
            // folderBrowserDialogbmp
            // 
            this.folderBrowserDialogbmp.SelectedPath = "C:\\Program Files (x86)\\GAINAX\\IRONMAIDEN2";
            // 
            // bmpviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(81)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(672, 448);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bmpviewer";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.bmpviewer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList bmpfiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxImages;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog Filedialogbmp;
        private System.Windows.Forms.Label filename_label;
        private System.Windows.Forms.Button compilarbutton;
        private System.Windows.Forms.Button extraerbutton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogbmp;
    }
}