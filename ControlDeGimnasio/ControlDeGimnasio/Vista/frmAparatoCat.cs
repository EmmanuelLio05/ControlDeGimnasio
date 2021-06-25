using System;
using System.Windows.Forms;
using Entidades = ControlDeGimnasio.Modelo.Entidades;
using Datos = ControlDeGimnasio.Modelo.Datos;

namespace ControlDeGimnasio.Vista {
    public partial class frmAparatoCat : Form {
        private Datos.Aparato oDAparato = new Datos.Aparato();
        private Entidades.Aparatos oEAparatos = new Entidades.Aparatos();

        #region Metodos
        public frmAparatoCat() {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void btnRegistrar_Click(object sender, EventArgs e) {
            frmAparato f = new frmAparato();

            f.Accion = Modelo.Entidades.Acciones.Registrar;
            f.ShowDialog();
        }

        private void btnActulizar_Click(object sender, EventArgs e) {
            frmAparato f = new frmAparato();

            f.Accion = Modelo.Entidades.Acciones.Actualizar;
            f.ID = Convert.ToInt32(dgvAparatos.SelectedRows[0].Cells["Nombre"].Value);
            f.ShowDialog();
        }

        private void frmAparatoCat_Load(object sender, EventArgs e) {
            oEAparatos = oDAparato.GetAll();
            dgvAparatos.DataSource = oEAparatos;
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmAparatoCat_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
        #endregion
    }
}
