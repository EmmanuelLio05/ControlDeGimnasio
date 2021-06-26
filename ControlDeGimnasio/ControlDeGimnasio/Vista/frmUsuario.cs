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

//Revisar por que marca error en Acciones y sUsuario

namespace ControlDeGimnasio.Vista
{
    public partial class frmUsuario : Form {
        private Modelo.Entidades.Acciones _Accion = Modelo.Entidades.Acciones.Registrar;
        private Modelo.Datos.Usuario oDUsuario = new Modelo.Datos.Usuario();
        private Modelo.Entidades.Usuario oEUsuario = new Modelo.Entidades.Usuario();
        private int nUsuario;

        #region Propiedades
        public Modelo.Entidades.Acciones Accion
        {
            get { return _Accion; }
            set { _Accion = value; }
        }

        public int Usuario
        {
            get { return nUsuario; }
            set { nUsuario = value; }
        }
        #endregion

        #region Metodos
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void Guardar()
        {
            if (Validar())
            {
                PrepararDatos();
                switch (_Accion)
                {
                    case Entidades.Acciones.Registrar:
                        oDUsuario.Add(oEUsuario);
                        break;
                    case Entidades.Acciones.Actualizar:
                        oDUsuario.Update(oEUsuario);
                        break;
                    default:
                        break;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private bool Validar()
        {
            if (txtNombre.Text != null)
            {
                if (txtNombre.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe indicar el nombre", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe indicar el nombre.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtContraseña.Text != null)
            {
                if (txtContraseña.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe indicar la contraseña", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe indicar la contraseña", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtProfesion.Text != null)
            {
                if (txtProfesion.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe indicar la profesión", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe indicar la profesión", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtDireccion.Text != null)
            {
                if (txtDireccion.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe indicar la dirección", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe indicar la dirección", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtTelefono.Text != null)
            {
                if (txtTelefono.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe indicar el teléfono", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe indicar el teléfono.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void CargarDatos()
        {
            txtNombre.Text = oEUsuario.Nombre;
            txtContraseña.Text = oEUsuario.Contraseña;
            txtDireccion.Text = oEUsuario.Direccion;
            txtProfesion.Text = oEUsuario.Profesion;
            txtTelefono.Text = oEUsuario.Telefono;

        }

        private void PrepararDatos()
        {
            oEUsuario.Nombre = txtNombre.Text;
            oEUsuario.Contraseña = txtContraseña.Text;
            oEUsuario.Direccion = txtDireccion.Text;
            oEUsuario.Profesion = txtProfesion.Text;
            oEUsuario.Telefono = txtTelefono.Text;

        }

        #endregion

        #region Eventos

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
           
            switch (_Accion)
            {
                case Entidades.Acciones.Registrar:
                   
                    break;
                case Entidades.Acciones.Actualizar:
                    if (nUsuario != 0)
                    {
                        oEUsuario = oDUsuario.GetOne(nUsuario);
                        CargarDatos();
                    }
                    break;
                case Entidades.Acciones.Consultar:
                    if (nUsuario != 0)
                    {
                        oEUsuario = oDUsuario.GetOne(nUsuario);
                        CargarDatos();
                    }
                    btnGuardar.Enabled = false;
                    break;
            }

        }


        private void frmClase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }


        #endregion






        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
