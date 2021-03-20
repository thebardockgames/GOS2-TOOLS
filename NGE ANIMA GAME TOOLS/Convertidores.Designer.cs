
namespace NGE_ANIMA_GAME_TOOLS
{
    partial class convertidores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(convertidores));
            this.tx3_txt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tx3file = new System.Windows.Forms.OpenFileDialog();
            this.txtfile = new System.Windows.Forms.OpenFileDialog();
            this.bmp_bp3 = new System.Windows.Forms.Button();
            this.bp3_bmp = new System.Windows.Forms.Button();
            this.dialogos_label = new System.Windows.Forms.Label();
            this.imagenes_label = new System.Windows.Forms.Label();
            this.bp3file = new System.Windows.Forms.OpenFileDialog();
            this.bmpfile = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tx3_txt
            // 
            this.tx3_txt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(81)))), ((int)(((byte)(180)))));
            this.tx3_txt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(109)))), ((int)(((byte)(60)))));
            this.tx3_txt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(229)))), ((int)(((byte)(89)))));
            this.tx3_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tx3_txt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx3_txt.ForeColor = System.Drawing.Color.White;
            this.tx3_txt.Location = new System.Drawing.Point(74, 155);
            this.tx3_txt.Name = "tx3_txt";
            this.tx3_txt.Size = new System.Drawing.Size(121, 23);
            this.tx3_txt.TabIndex = 2;
            this.tx3_txt.Text = "TX3 A TXT";
            this.tx3_txt.UseVisualStyleBackColor = true;
            this.tx3_txt.Click += new System.EventHandler(this.tx3_txt_Click);
            this.tx3_txt.MouseEnter += new System.EventHandler(this.DESEMPAQUETAR_MouseEnter);
            this.tx3_txt.MouseLeave += new System.EventHandler(this.DESEMPAQUETAR_MouseLeave);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(81)))), ((int)(((byte)(180)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(109)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(229)))), ((int)(((byte)(89)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(74, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "TXT A TX3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // tx3file
            // 
            this.tx3file.FileName = "t*.tx3";
            this.tx3file.Filter = "\"tx3 files\" (*.tx3)|*.tx3";
            this.tx3file.InitialDirectory = "C:\\Program Files (x86)\\GAINAX\\IRONMAIDEN2";
            // 
            // txtfile
            // 
            this.txtfile.FileName = "t*.txt";
            this.txtfile.Filter = "\"txt files\" (*.txt)|*.txt";
            this.txtfile.InitialDirectory = "C:\\Program Files (x86)\\GAINAX\\IRONMAIDEN2";
            // 
            // bmp_bp3
            // 
            this.bmp_bp3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(81)))), ((int)(((byte)(180)))));
            this.bmp_bp3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(109)))), ((int)(((byte)(60)))));
            this.bmp_bp3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(229)))), ((int)(((byte)(89)))));
            this.bmp_bp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmp_bp3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmp_bp3.ForeColor = System.Drawing.Color.White;
            this.bmp_bp3.Location = new System.Drawing.Point(72, 323);
            this.bmp_bp3.Name = "bmp_bp3";
            this.bmp_bp3.Size = new System.Drawing.Size(121, 23);
            this.bmp_bp3.TabIndex = 6;
            this.bmp_bp3.Text = "BMP A BP3";
            this.bmp_bp3.UseVisualStyleBackColor = true;
            this.bmp_bp3.Click += new System.EventHandler(this.bmp_bp3_Click);
            this.bmp_bp3.MouseEnter += new System.EventHandler(this.bmp_bp3_MouseEnter);
            this.bmp_bp3.MouseLeave += new System.EventHandler(this.bmp_bp3_MouseLeave);
            // 
            // bp3_bmp
            // 
            this.bp3_bmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(81)))), ((int)(((byte)(180)))));
            this.bp3_bmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(109)))), ((int)(((byte)(60)))));
            this.bp3_bmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(229)))), ((int)(((byte)(89)))));
            this.bp3_bmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bp3_bmp.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bp3_bmp.ForeColor = System.Drawing.Color.White;
            this.bp3_bmp.Location = new System.Drawing.Point(72, 285);
            this.bp3_bmp.Name = "bp3_bmp";
            this.bp3_bmp.Size = new System.Drawing.Size(121, 23);
            this.bp3_bmp.TabIndex = 5;
            this.bp3_bmp.Text = "BP3 A BMP";
            this.bp3_bmp.UseVisualStyleBackColor = true;
            this.bp3_bmp.Click += new System.EventHandler(this.bp3_bmp_Click);
            this.bp3_bmp.MouseEnter += new System.EventHandler(this.bp3_bmp_MouseEnter);
            this.bp3_bmp.MouseLeave += new System.EventHandler(this.bp3_bmp_MouseLeave);
            // 
            // dialogos_label
            // 
            this.dialogos_label.AutoSize = true;
            this.dialogos_label.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogos_label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dialogos_label.Location = new System.Drawing.Point(90, 131);
            this.dialogos_label.Name = "dialogos_label";
            this.dialogos_label.Size = new System.Drawing.Size(89, 17);
            this.dialogos_label.TabIndex = 1;
            this.dialogos_label.Text = "DIALOGOS";
            this.dialogos_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imagenes_label
            // 
            this.imagenes_label.AutoSize = true;
            this.imagenes_label.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagenes_label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.imagenes_label.Location = new System.Drawing.Point(90, 251);
            this.imagenes_label.Name = "imagenes_label";
            this.imagenes_label.Size = new System.Drawing.Size(90, 17);
            this.imagenes_label.TabIndex = 7;
            this.imagenes_label.Text = "IMAGENES";
            this.imagenes_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bp3file
            // 
            this.bp3file.FileName = "*.bp3";
            this.bp3file.Filter = "\"bp3 files\" (*.bp3)|*.bp3";
            this.bp3file.InitialDirectory = "C:\\Program Files (x86)\\GAINAX\\IRONMAIDEN2";
            // 
            // bmpfile
            // 
            this.bmpfile.FileName = "*.bmp";
            this.bmpfile.Filter = "\"bmp files\" (*.bmp)|*.bmp";
            this.bmpfile.InitialDirectory = "C:\\Program Files (x86)\\GAINAX\\IRONMAIDEN2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::NGE_ANIMA_GAME_TOOLS.Properties.Resources.eva_black;
            this.pictureBox2.Location = new System.Drawing.Point(132, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(539, 450);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // convertidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(81)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.imagenes_label);
            this.Controls.Add(this.dialogos_label);
            this.Controls.Add(this.bmp_bp3);
            this.Controls.Add(this.bp3_bmp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx3_txt);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "convertidores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tx3_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog tx3file;
        private System.Windows.Forms.OpenFileDialog txtfile;
        private System.Windows.Forms.Button bmp_bp3;
        private System.Windows.Forms.Button bp3_bmp;
        private System.Windows.Forms.Label dialogos_label;
        private System.Windows.Forms.Label imagenes_label;
        private System.Windows.Forms.OpenFileDialog bp3file;
        private System.Windows.Forms.OpenFileDialog bmpfile;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

