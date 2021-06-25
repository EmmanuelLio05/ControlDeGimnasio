using System;
using System.Windows.Forms;
using Entidades = ControlDeGimnasio.Modelo.Entidades;
using Datos = ControlDeGimnasio.Modelo.Datos;

namespace ControlDeGimnasio {
    public partial class frmSocio : Form {
        private Entidades.Acciones _Accion = Entidades.Acciones.Registrar;
        private int nID;
        private Entidades.Socio oESocio = new Entidades.Socio();
        private Datos.Socio oDSocio = new Datos.Socio();


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
        public frmSocio() {
            InitializeComponent();
        }

        public void Guardar() {
            if (Validar()) {
                PrepararDatos();
                switch (_Accion) {
                    case Entidades.Acciones.Registrar:
                        oDSocio.Add(oESocio);
                        break;
                    case Entidades.Acciones.Actualizar:
                        oDSocio.Update(oESocio);
                        break;
                    default:
                        break;
                }
            }
        }

        private bool Validar() {
            if (txtNombre.Text != null) {
                if (txtNombre.Text.Trim().Length == 0) {
                    MessageBox.Show("Debe indicar el nombre.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            } else {
                MessageBox.Show("Debe indicar el nombre.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            if (txtPaterno.Text != null) {
                if (txtPaterno.Text.Trim().Length == 0) {
                    MessageBox.Show("Debe indicar el apellido paterno.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            } else {
                MessageBox.Show("Debe indicar el apellido paterno.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPaterno.Focus();
                return false;
            }
            if (txtTelefono.Text != null) {
                if (txtTelefono.Text.Trim().Length == 0) {
                    MessageBox.Show("Debe indicar el teléfono.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            } else {
                MessageBox.Show("Debe indicar el teléfono.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }
            if (txtMonto.Text != null) {
                if (txtMonto.Text.Trim().Length == 0) {
                    MessageBox.Show("Debe indicar el monto.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                } else if (!Decimal.TryParse(txtMonto.Text.Trim(), out decimal d)){
                    MessageBox.Show("El monto debe ser un numero.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }else if (d < 0) {
                    MessageBox.Show("El monto debe ser un numero positivo.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            } else {
                MessageBox.Show("Debe indicar el monto.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
                return false;
            }
            return true;
        }

        private void CargarDatos() {
            txtNumero.Text = oESocio.Id.ToString();
            txtNombre.Text = oESocio.Nombre;
            txtPaterno.Text = oESocio.Paterno;
            txtMaterno.Text = oESocio.Materno;
            txtMaterno.Text = oESocio.Telefono;
            txtDireccion.Text = oESocio.Direccion;
            txtMonto.Text = String.Format("{0:C2}", oESocio.Monto);
            chkInscrito.Checked = oESocio.Inscrito;
            dtpFechaRegistro.Value = oESocio.FechaInscripcion;
        }

        private void PrepararDatos() {
            oESocio.Nombre = txtNombre.Text;
            oESocio.Paterno = txtPaterno.Text;
            oESocio.Materno = txtMaterno.Text;
            oESocio.Telefono = txtMaterno.Text;
            oESocio.Direccion = txtDireccion.Text;
            oESocio.Monto = Convert.ToDouble( txtMonto.Text);
            oESocio.Inscrito = chkInscrito.Checked;
            oESocio.FechaInscripcion = dtpFechaRegistro.Value;
        }
        #endregion

        #region Eventos
        private void frmRegistro_Load(object sender, EventArgs e) {
            switch (_Accion) {
                case Entidades.Acciones.Registrar:

                    break;
                case Entidades.Acciones.Actualizar:
                    if (nID != 0) {
                        oESocio = oDSocio.GetOne(nID);
                        CargarDatos();
                    }
                    break;
                case Entidades.Acciones.Consultar:
                    if (nID != 0) {
                        oESocio = oDSocio.GetOne(nID);
                        CargarDatos();
                    }
                    btnGuardar.Enabled = false;
                    break;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            Guardar();
        }

        private void toolStripButton3_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmRegistro_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void txtMonto_Leave(object sender, EventArgs e) {
            if (txtMonto.Text != null) {
                if (txtMonto.Text.Trim().Length > 0) {
                    if (!Decimal.TryParse(txtMonto.Text.Trim(), out decimal d)) {
                        MessageBox.Show("El monto debe ser un numero.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMonto.Focus();
                    } else if (d < 0) {
                        MessageBox.Show("El monto debe ser un numero positivo.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMonto.Focus();
                    }
                }
            }
        }
        #endregion
    }
}
