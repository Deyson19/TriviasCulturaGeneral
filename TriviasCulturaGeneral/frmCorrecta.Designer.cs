namespace TriviasCulturaGeneral
{
    partial class frmCorrecta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCorrecta));
            this.imgCorrecta = new System.Windows.Forms.PictureBox();
            this.lblCorrecta = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgCorrecta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCorrecta
            // 
            this.imgCorrecta.Image = ((System.Drawing.Image)(resources.GetObject("imgCorrecta.Image")));
            this.imgCorrecta.Location = new System.Drawing.Point(12, 60);
            this.imgCorrecta.Name = "imgCorrecta";
            this.imgCorrecta.Size = new System.Drawing.Size(177, 133);
            this.imgCorrecta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCorrecta.TabIndex = 0;
            this.imgCorrecta.TabStop = false;
            // 
            // lblCorrecta
            // 
            this.lblCorrecta.AutoSize = true;
            this.lblCorrecta.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCorrecta.Location = new System.Drawing.Point(128, 18);
            this.lblCorrecta.Name = "lblCorrecta";
            this.lblCorrecta.Size = new System.Drawing.Size(182, 25);
            this.lblCorrecta.TabIndex = 1;
            this.lblCorrecta.Text = "Respuesta Correcta";
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 20;
            this.btnCerrar.Location = new System.Drawing.Point(375, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(226, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frmCorrecta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 233);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblCorrecta);
            this.Controls.Add(this.imgCorrecta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCorrecta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Respuesta Correcta";
            ((System.ComponentModel.ISupportInitialize)(this.imgCorrecta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCorrecta;
        private System.Windows.Forms.Label lblCorrecta;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}