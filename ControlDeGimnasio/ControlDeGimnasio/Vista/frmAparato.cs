using System;
using System.Windows.Forms;
using Entidades = ControlDeGimnasio.Modelo.Entidades;
using Datos = ControlDeGimnasio.Modelo.Datos;

namespace ControlDeGimnasio.Vista {
    public partial class frmAparato : Form {
        private Entidades.Acciones _Accion = Modelo.Entidades.Acciones.Registrar;
        private int nID;
        private Datos.Aparato oDAparato = new Modelo.Datos.Aparato();
        private Entidades.Aparato oEAparato = new Modelo.Entidades.Aparato();

        #region Propiedades
        public Modelo.Entidades.Acciones Accion {
            get { return _Accion; }
            set { _Accion = value; }
        }

        public int ID {
            get { return nID; }
            set { nID = value; }
        }
        #endregion

        #region Metodos
        public frmAparato() {
            InitializeComponent();
        }

        public void Guardar() {
            if (Validar()){
                PrepararDatos();
                switch (_Accion) {
                    case Entidades.Acciones.Registrar:
                        oDAparato.Add(oEAparato);
                        break;
                    case Entidades.Acciones.Actualizar:
                        oDAparato.Update(oEAparato);
                        break;
                    default:
                        break;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool Validar() {
            if (txtAparato.Text != null) {
                if (txtAparato.Text.Trim().Length == 0) {
                    MessageBox.Show("Debe indicar el nombre", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            } else {
                MessageBox.Show("Debe indicar el nombre.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void CargarDatos() {
            txtAparato.Text = oEAparato.Descripcion;
            txtClave.Text = oEAparato.Id.ToString();
            chkEstado.Checked = oEAparato.Estado;
        }

        private void PrepararDatos() {
            oEAparato.Descripcion = txtAparato.Text;
            oEAparato.Id = Convert.ToInt32(txtClave.Text);
            oEAparato.Estado = chkEstado.Checked;
        }
        #endregion

        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e) {
            Guardar();
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e) {
            //if (chkEstado.Checked)
            //    chkEstado.ForeColor = new System.Drawing.Color
            //else
            //    chkEstado.Font = null;
        }

        private void frmAparato_Load(object sender, EventArgs e) {
            switch (_Accion) {
                case Entidades.Acciones.Registrar:

                    break;
                case Entidades.Acciones.Actualizar:
                    if (nID != 0) {
                        oEAparato = oDAparato.GetOne(nID);
                        CargarDatos();
                    }
                    txtClave.Enabled = false;
                    break;
                case Entidades.Acciones.Consultar:
                    if (nID != 0) {
                        oEAparato = oDAparato.GetOne(nID);
                        CargarDatos();
                    }
                    btnGuardar.Enabled = false;
                    break;
            }
        }

        private void frmAparato_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
        #endregion
    }
}