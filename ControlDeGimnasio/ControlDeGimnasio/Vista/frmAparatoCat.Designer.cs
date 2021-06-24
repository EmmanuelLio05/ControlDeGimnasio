
namespace ControlDeGimnasio.Vista {
    partial class frmAparatoCat {
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
            this.dgvClases = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActulizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.bsAparato = new System.Windows.Forms.BindingSource(this.components);
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAparato)).BeginInit();
            this.SuspendLayout();
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
            this.estadoDataGridViewCheckBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dgvClases.DataSource = this.bsAparato;
            this.dgvClases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClases.Location = new System.Drawing.Point(60, 0);
            this.dgvClases.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClases.MultiSelect = false;
            this.dgvClases.Name = "dgvClases";
            this.dgvClases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClases.Size = new System.Drawing.Size(1007, 623);
            this.dgvClases.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnActulizar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 623);
            this.panel1.TabIndex = 3;
            // 
            // btnActulizar
            // 
            this.btnActulizar.Location = new System.Drawing.Point(4, 73);
            this.btnActulizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(52, 32);
            this.btnActulizar.TabIndex = 2;
            this.btnActulizar.Text = "button2";
            this.btnActulizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(4, 130);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(52, 32);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "button2";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(4, 19);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(52, 32);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "button1";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // bsAparato
            // 
            this.bsAparato.DataSource = typeof(ControlDeGimnasio.Modelo.Entidades.Aparato);
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // frmAparatoCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.dgvClases);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAparatoCat";
            this.Text = "frmAparatoCat";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsAparato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClases;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActulizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.BindingSource bsAparato;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}