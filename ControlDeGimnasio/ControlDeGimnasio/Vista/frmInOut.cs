using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades = ControlDeGimnasio.Modelo.Entidades;
using Datos = ControlDeGimnasio.Modelo.Datos;

namespace ControlDeGimnasio.Vista {
    public partial class frmInOut : Form {
        Entidades.Registros oERegistros = new Entidades.Registros();
        Datos.Registro oDRegistro = new Datos.Registro();
        Datos.Socio oDSocio = new Datos.Socio();

        #region Metodos
        public frmInOut() {
            InitializeComponent();
        }

        private bool Validar() {
            if (txtSocio.Text != null) {
                if (txtSocio.Text.Trim().Length > 0) {
                    if (!Int32.TryParse(txtSocio.Text.Trim(), out int n)) {
                        MessageBox.Show("El numero de socio debe ser un numero.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSocio.Text = "";
                        txtSocio.Focus();
                        return false;
                    } else if (n <= 0) {
                        MessageBox.Show("El numero de socio debe ser un numero positivo.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSocio.Focus();
                        return false;
                    }
                } else {
                    MessageBox.Show("Indique el numero de socio.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSocio.Focus();
                    return false;
                }
                if (oERegistros.Count > 0)
                    if (!oERegistros.All(registro => (registro.Socio != Convert.ToInt32(txtSocio.Text.Trim())))) {
                        MessageBox.Show("El socio ya esta adentro.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSocio.Focus();
                        return false;
                    }
                if (oDSocio.GetOne(Convert.ToInt32(txtSocio.Text.Trim())) == null) {
                    MessageBox.Show("No existe un socio con ese numero.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSocio.Focus();
                    return false;
                }
            } else {
                MessageBox.Show("Indique el numero de socio.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSocio.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region Eventos
        private void frmInOut_Load(object sender, EventArgs e) {
            dgvSociosEnGym.DataSource = oERegistros;
        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            Entidades.Registro oRegistroAux = new Entidades.Registro();

            try {
                if (Validar()) {
                    oRegistroAux.ID = Convert.ToInt32(oDRegistro.SelectMaxId()) + 1;
                    oRegistroAux.Socio = Convert.ToInt32(txtSocio.Text.Trim());
                    oRegistroAux.HoraEntrada = DateTime.Now;
                    oRegistroAux.NombreSocio = oDSocio.GetOne(Convert.ToInt32(txtSocio.Text.Trim())).Nombre;
                    oDRegistro.In(oRegistroAux);
                    oERegistros.Add(oRegistroAux);
                    dgvSociosEnGym.Refresh();
                    txtSocio.Text = "";
                }
            } catch (Exception ex) {
                MessageBox.Show("error:" + ex.Message, "btnEntrar_Click", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvSociosEnGym_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            try {
                oERegistros[dgvSociosEnGym.SelectedRows[0].Index].HoraSalida = DateTime.Now;
                oDRegistro.Out(oERegistros[dgvSociosEnGym.SelectedRows[0].Index]);
                oERegistros.Remove(oERegistros[dgvSociosEnGym.SelectedRows[0].Index]);
                dgvSociosEnGym.Refresh();
            } catch (Exception ex) { 

            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void txtUsuario_Leave(object sender, EventArgs e) {
            if (txtSocio.Text != null) {
                if (txtSocio.Text.Trim().Length > 0) {
                    if (!Int32.TryParse(txtSocio.Text.Trim(), out int n)) {
                        MessageBox.Show("El numero de socio debe ser un numero.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSocio.Text = "";
                        txtSocio.Focus();
                    } else if (n <= 0) {
                        MessageBox.Show("El numero de socio debe ser un numero positivo.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSocio.Focus();
                    }
                }
            }
        }
        #endregion

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnEntrar.PerformClick();
            }
        }

        private void frmInOut_FormClosed(object sender, FormClosedEventArgs e) {
            foreach(Entidades.Registro registro in oERegistros){
                registro.HoraSalida = DateTime.Now;
                oDRegistro.Out(registro);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.ShowDialog();
        }
        */
    }
}
