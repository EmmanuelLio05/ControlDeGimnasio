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
    public partial class frmSociosCat : Form {
        private Modelo.Datos.Socio oDSocio = new Modelo.Datos.Socio();
        private Modelo.Entidades.Socios oESocios = new Modelo.Entidades.Socios();

        #region Metodos
        public frmSociosCat() {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void frmSociosCat_Load(object sender, EventArgs e) {
            oESocios = oDSocio.GetAll();
            dgvSocios.DataSource = oESocios;
        }

        private void tsbSalir_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tsbModificar_Click(object sender, EventArgs e) {
            frmSocio f = new frmSocio();

            f.Accion = Modelo.Entidades.Acciones.Actualizar;
            f.ID = Convert.ToInt32(dgvSocios.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);
            if (f.ShowDialog() == DialogResult.OK) {
                oESocios = oDSocio.GetAll();
                dgvSocios.DataSource = oESocios;
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e) {
            frmSocio f = new frmSocio();

            f.Accion = Modelo.Entidades.Acciones.Registrar;
            if (f.ShowDialog() == DialogResult.OK) {
                oESocios = oDSocio.GetAll();
                dgvSocios.DataSource = oESocios;
            }
        }

        private void frmSociosCat_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
        #endregion
    }
}
