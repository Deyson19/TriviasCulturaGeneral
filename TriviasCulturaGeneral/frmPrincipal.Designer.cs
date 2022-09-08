namespace TriviasCulturaGeneral
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnIrATrivia = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(219, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(155, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trivias de Cultura General";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(226, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.lblGrupo);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 43);
            this.panel1.TabIndex = 3;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGrupo.Location = new System.Drawing.Point(261, 9);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(282, 25);
            this.lblGrupo.TabIndex = 1;
            this.lblGrupo.Text = "Grupo colaborativo: 204024_8";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(92, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(134, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Deyson Vente";
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(415, 189);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(137, 29);
            this.btnEmpezar.TabIndex = 4;
            this.btnEmpezar.Text = "Empezar Trivia";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Visible = false;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnIrATrivia
            // 
            this.btnIrATrivia.FlatAppearance.BorderSize = 0;
            this.btnIrATrivia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrATrivia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIrATrivia.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnIrATrivia.IconChar = FontAwesome.Sharp.IconChar.CirclePlay;
            this.btnIrATrivia.IconColor = System.Drawing.Color.Black;
            this.btnIrATrivia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIrATrivia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIrATrivia.Location = new System.Drawing.Point(184, 252);
            this.btnIrATrivia.Name = "btnIrATrivia";
            this.btnIrATrivia.Size = new System.Drawing.Size(189, 49);
            this.btnIrATrivia.TabIndex = 5;
            this.btnIrATrivia.Text = "Empezar la Trivia";
            this.btnIrATrivia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIrATrivia.UseVisualStyleBackColor = true;
            this.btnIrATrivia.Click += new System.EventHandler(this.btnIrATrivia_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 20;
            this.btnCerrar.Location = new System.Drawing.Point(529, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 23);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(573, 350);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnIrATrivia);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnEmpezar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private FontAwesome.Sharp.IconButton btnIrATrivia;
        private FontAwesome.Sharp.IconButton btnCerrar;
    }
}
