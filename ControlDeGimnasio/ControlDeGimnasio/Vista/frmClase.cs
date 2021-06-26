using System;
using System.Windows.Forms;
using ControlDeGimnasio.Modelo.Entidades;
using ControlDeGimnasio.Modelo.Datos;

namespace ControlDeGimnasio.Vista {
    public partial class frmClase : Form {
        private Modelo.Entidades.Acciones _Accion = Modelo.Entidades.Acciones.Registrar;
        private Modelo.Datos.Clase oDClase = new Modelo.Datos.Clase();
        private Modelo.Entidades.Clase oEClase = new Modelo.Entidades.Clase();
        private String sClase;

        #region Propiedades
        public Modelo.Entidades.Acciones Accion {
            get { return _Accion; }
            set { _Accion = value; }
        }

        public String Clase {
            get { return sClase; }
            set { sClase = value; }
        }
        #endregion

        #region Metodos
        public frmClase() {
            InitializeComponent();
        }

        private void Guardar() {
            if (Validar()) {
                PrepararDatos();
                switch (_Accion) {
                    case Acciones.Registrar:
                        oDClase.Add(oEClase);
                        break;
                    case Acciones.Actualizar:
                        oDClase.Update(oEClase);
                        break;
                    default:
                        break;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool Validar() {
            if (txtNombre.Text != null) {
                if (txtNombre.Text.Trim().Length == 0) {
                    MessageBox.Show("Debe indicar el nombre", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            } else {
                MessageBox.Show("Debe indicar el nombre.","Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Convert.ToInt32( cmbEntrenador.SelectedValue) == 0) {
                MessageBox.Show("Debe indicar el entrenador.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpHora.Value.ToLocalTime() != new DateTime(1900,1,1,0,0,0)) {
                MessageBox.Show("Debe indicar la hora.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void CargarDatos() {
            txtNombre.Text = oEClase.Nombre;
            txtDescripcion.Text = oEClase.Descripcion;
            cmbEntrenador.SelectedValue = oEClase.Entrenador;
            dtpHora.Value = oEClase.Hora;
        }

        private void PrepararDatos() {
            oEClase.Nombre = txtNombre.Text;
            oEClase.Descripcion = txtDescripcion.Text;
            oEClase.Entrenador = Convert.ToInt32(cmbEntrenador.SelectedValue);
            oEClase.Hora = dtpHora.Value;
        }

        private void CargarCombos() {
            Modelo.Datos.Usuario oDUsuario = new Modelo.Datos.Usuario();
            Modelo.Entidades.Usuarios oEUsuarios = new Modelo.Entidades.Usuarios();

            oEUsuarios = oDUsuario.GetAll();
            cmbEntrenador.DataSource = oEUsuarios;
            cmbEntrenador.DisplayMember = "Nombre";
            cmbEntrenador.ValueMember = "ID";
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

        private void frmClase_Load(object sender, EventArgs e) {
            CargarCombos();
            switch (_Accion) {
                case Acciones.Registrar:

                    break;
                case Acciones.Actualizar:
                    if (sClase != null) {
                        oEClase = oDClase.GetOne(sClase);
                        CargarDatos();
                    }
                    txtNombre.Enabled = false;
                    break;
                case Acciones.Consultar:
                    if (sClase != null) {
                        oEClase = oDClase.GetOne(sClase);
                        CargarDatos();
                    }
                    btnGuardar.Enabled = false;
                    break;
            }
        }

        private void frmClase_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}