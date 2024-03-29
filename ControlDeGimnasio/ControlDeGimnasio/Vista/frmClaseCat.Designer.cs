﻿
namespace ControlDeGimnasio.Vista {
    partial class frmClaseCat {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClaseCat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActulizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvClases = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrenadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsClase = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClase)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnActulizar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 234);
            this.panel1.TabIndex = 1;
            // 
            // btnActulizar
            // 
            this.btnActulizar.Image = global::ControlDeGimnasio.Properties.Resources._30pencil;
            this.btnActulizar.Location = new System.Drawing.Point(3, 54);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(38, 38);
            this.btnActulizar.TabIndex = 2;
            this.btnActulizar.UseVisualStyleBackColor = true;
            this.btnActulizar.Click += new System.EventHandler(this.btnActulizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ControlDeGimnasio.Properties.Resources._24close;
            this.btnSalir.Location = new System.Drawing.Point(3, 94);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(38, 38);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = global::ControlDeGimnasio.Properties.Resources._30plus;
            this.btnRegistrar.Location = new System.Drawing.Point(3, 14);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(38, 38);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvClases
            // 
            this.dgvClases.AllowUserToAddRows = false;
            this.dgvClases.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.dgvClases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClases.AutoGenerateColumns = false;
            this.dgvClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.entrenadorDataGridViewTextBoxColumn});
            this.dgvClases.DataSource = this.bsClase;
            this.dgvClases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClases.Location = new System.Drawing.Point(45, 0);
            this.dgvClases.MultiSelect = false;
            this.dgvClases.Name = "dgvClases";
            this.dgvClases.ReadOnly = true;
            this.dgvClases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClases.Size = new System.Drawing.Size(444, 234);
            this.dgvClases.TabIndex = 2;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entrenadorDataGridViewTextBoxColumn
            // 
            this.entrenadorDataGridViewTextBoxColumn.DataPropertyName = "Entrenador";
            this.entrenadorDataGridViewTextBoxColumn.HeaderText = "Entrenador";
            this.entrenadorDataGridViewTextBoxColumn.Name = "entrenadorDataGridViewTextBoxColumn";
            this.entrenadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsClase
            // 
            this.bsClase.DataSource = typeof(ControlDeGimnasio.Modelo.Entidades.Clase);
            // 
            // frmClaseCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 234);
            this.Controls.Add(this.dgvClases);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmClaseCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo de clases";
            this.Load += new System.EventHandler(this.frmClaseCat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmClaseCat_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvClases;
        private System.Windows.Forms.BindingSource bsClase;
        private System.Windows.Forms.Button btnActulizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrenadorDataGridViewTextBoxColumn;
    }
}