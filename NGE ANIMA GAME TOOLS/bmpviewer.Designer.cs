
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
            this.Filedialogbmp = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogbmp = new System.Windows.Forms.FolderBrowserDialog();
            this.remasterbutton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listbox_filesbase = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(542, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 280);
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
            this.listBoxImages.Location = new System.Drawing.Point(3, 91);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.Size = new System.Drawing.Size(114, 186);
            this.listBoxImages.TabIndex = 0;
            this.listBoxImages.SelectedIndexChanged += new System.EventHandler(this.listBoxImages_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // remasterbutton
            // 
            this.remasterbutton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remasterbutton.ForeColor = System.Drawing.Color.Black;
            this.remasterbutton.Location = new System.Drawing.Point(3, 18);
            this.remasterbutton.Name = "remasterbutton";
            this.remasterbutton.Size = new System.Drawing.Size(114, 23);
            this.remasterbutton.TabIndex = 12;
            this.remasterbutton.Text = "Remasterizar";
            this.remasterbutton.UseVisualStyleBackColor = true;
            this.remasterbutton.Click += new System.EventHandler(this.remasterbutton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.remasterbutton);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(542, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 47);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Realesrgan (AI)";
            this.groupBox3.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listbox_filesbase);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(541, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(118, 104);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Archivos (Base)";
            // 
            // listbox_filesbase
            // 
            this.listbox_filesbase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox_filesbase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(81)))), ((int)(((byte)(180)))));
            this.listbox_filesbase.ForeColor = System.Drawing.Color.White;
            this.listbox_filesbase.FormattingEnabled = true;
            this.listbox_filesbase.Location = new System.Drawing.Point(1, 19);
            this.listbox_filesbase.Name = "listbox_filesbase";
            this.listbox_filesbase.Size = new System.Drawing.Size(114, 82);
            this.listbox_filesbase.TabIndex = 10;
            this.listbox_filesbase.SelectedIndexChanged += new System.EventHandler(this.listbox_filesbase_SelectedIndexChanged);
            // 
            // bmpviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(81)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(672, 448);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList bmpfiles;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox listBoxImages;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog Filedialogbmp;
        private System.Windows.Forms.Label filename_label;
        private System.Windows.Forms.Button compilarbutton;
        private System.Windows.Forms.Button extraerbutton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogbmp;
        private System.Windows.Forms.Button remasterbutton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.ListBox listbox_filesbase;
    }
}