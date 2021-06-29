using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeGimnasio.Vista {
    public partial class frmClaseCat : Form {
        private Modelo.Datos.Clase oDClase = new Modelo.Datos.Clase();
        private Modelo.Entidades.Clases oEClases = new Modelo.Entidades.Clases();

        #region Metodos
        public frmClaseCat() {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void frmClaseCat_Load(object sender, EventArgs e) {
            oEClases = oDClase.GetAll();
            dgvClases.DataSource = oEClases;
        }

        private void btnActulizar_Click(object sender, EventArgs e) {
            frmClase f = new frmClase();
            
            f.Accion = Modelo.Entidades.Acciones.Actualizar;
            f.Clase = Convert.ToString( dgvClases.SelectedRows[0].Cells["nombreDataGridViewTextBoxColumn"].Value);
            f.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            frmClase f = new frmClase();
            
            f.Accion = Modelo.Entidades.Acciones.Registrar;
            f.ShowDialog();
        }

        private void frmClaseCat_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
        #endregion

        private void btnSalir_Click_1(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
