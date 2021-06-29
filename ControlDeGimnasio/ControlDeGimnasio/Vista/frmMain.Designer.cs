
namespace ControlDeGimnasio.Vista {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSocios = new System.Windows.Forms.Button();
            this.btnAparatos = new System.Windows.Forms.Button();
            this.btnClases = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Image = global::ControlDeGimnasio.Properties.Resources._50logout;
            this.btnLogout.Location = new System.Drawing.Point(485, 339);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 75);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.Image = global::ControlDeGimnasio.Properties.Resources._50about;
            this.btnAbout.Location = new System.Drawing.Point(402, 256);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 75);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSocios
            // 
            this.btnSocios.BackColor = System.Drawing.Color.Transparent;
            this.btnSocios.Image = global::ControlDeGimnasio.Properties.Resources._150socios;
            this.btnSocios.Location = new System.Drawing.Point(12, 85);
            this.btnSocios.Name = "btnSocios";
            this.btnSocios.Size = new System.Drawing.Size(158, 158);
            this.btnSocios.TabIndex = 1;
            this.btnSocios.UseVisualStyleBackColor = false;
            this.btnSocios.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAparatos
            // 
            this.btnAparatos.BackColor = System.Drawing.Color.Transparent;
            this.btnAparatos.Image = global::ControlDeGimnasio.Properties.Resources._150Aparato;
            this.btnAparatos.Location = new System.Drawing.Point(207, 85);
            this.btnAparatos.Name = "btnAparatos";
            this.btnAparatos.Size = new System.Drawing.Size(158, 158);
            this.btnAparatos.TabIndex = 2;
            this.btnAparatos.UseVisualStyleBackColor = false;
            this.btnAparatos.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnClases
            // 
            this.btnClases.BackColor = System.Drawing.Color.Transparent;
            this.btnClases.Image = global::ControlDeGimnasio.Properties.Resources._150clase;
            this.btnClases.Location = new System.Drawing.Point(402, 85);
            this.btnClases.Name = "btnClases";
            this.btnClases.Size = new System.Drawing.Size(158, 158);
            this.btnClases.TabIndex = 3;
            this.btnClases.UseVisualStyleBackColor = false;
            this.btnClases.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Image = global::ControlDeGimnasio.Properties.Resources._150usuario;
            this.btnUsuarios.Location = new System.Drawing.Point(12, 256);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(158, 158);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.Image = global::ControlDeGimnasio.Properties.Resources._150reporte;
            this.btnReportes.Location = new System.Drawing.Point(207, 256);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(158, 158);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnOfertas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gimnasio VO2MAX";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(576, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSocios);
            this.Controls.Add(this.btnAparatos);
            this.Controls.Add(this.btnClases);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnReportes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnClases;
        private System.Windows.Forms.Button btnAparatos;
        private System.Windows.Forms.Button btnSocios;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
    }
}