using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeGimnasio.Vista
{
    public partial class frmUsuarioCat : Form
    {
        private Modelo.Datos.Usuario oDUsuario = new Modelo.Datos.Usuario();
        private Modelo.Entidades.Usuarios oEUsuarios = new Modelo.Entidades.Usuarios();


        #region Métodos
        public frmUsuarioCat()
        {
            InitializeComponent();
        }


        #endregion

        #region Eventos
        private void frmUsuarioCat_Load(object sender, EventArgs e)
        {
            oEUsuarios = oDUsuario.GetAll();
            dgvUsuarios.DataSource = oEUsuarios;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmUsuario f = new frmUsuario();

            f.Accion = Modelo.Entidades.Acciones.Registrar;
            if (f.ShowDialog() == DialogResult.OK) {
                oEUsuarios = oDUsuario.GetAll();
                dgvUsuarios.DataSource = oEUsuarios;
            }

        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            frmUsuario f = new frmUsuario();

            f.Accion = Modelo.Entidades.Acciones.Actualizar;

            f.Usuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value);
            if (f.ShowDialog() == DialogResult.OK) {
                oEUsuarios = oDUsuario.GetAll();
                dgvUsuarios.DataSource = oEUsuarios;
            }

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void frmClaseCat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }


        #endregion



        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

    
    }
}
