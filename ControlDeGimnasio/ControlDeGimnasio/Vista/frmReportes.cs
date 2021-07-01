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
    public partial class frmReportes : Form {
        private Datos.Aparato oDAparato = new Datos.Aparato();
        private Datos.Socio oDSocio = new Datos.Socio();
        private Datos.Registro oDRegistro = new Datos.Registro();
        private Entidades.Aparatos oEAparatos = new Entidades.Aparatos();
        private Entidades.Socios oESocios = new Entidades.Socios();
        private Entidades.Registros oERegistros = new Entidades.Registros();

        #region Metodos
        public frmReportes() {
            InitializeComponent();
        }

        private void BusquedaRegistros() {
            string sSql = "SELECT * FROM dbo.Registros r INNER JOIN dbo.Socio s ON s.Numero_S = r.Numero_S WHERE ";
            DateTime odAux;

            try {
                odAux = (dtpA.Value + new TimeSpan(24, 0, 0));
                if (odAux >= dtpDe.Value){
                    sSql += "Hora_Entrada >= '" + dtpDe.Value.Year + "-" + dtpDe.Value.Month + "-" + dtpDe.Value.Day + " " + dtpDe.Value.ToShortTimeString()  + "' AND Hora_Salida <= '" + odAux.Year + "-" + odAux.Month + "-" + odAux.Day + " " + odAux.ToShortTimeString() + "'";
                }
                oERegistros = oDRegistro.Busqueda(sSql);
                dgvRegistros.DataSource = oERegistros;
                dgvRegistros.Refresh();
            } catch (Exception ex) {
                MessageBox.Show("error: " + ex.Message, "BusquedaRegistros");
            }
        }
        #endregion

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e) {
            BusquedaRegistros();
        }

        private void frmReportes_Load(object sender, EventArgs e) {
            dgvSocios.DataSource = oDSocio.GetInformacion();
            dgvAparatos.DataSource = oDAparato.GetInformacion();
            BusquedaRegistros();
        }

        private void frmReportes_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void tsbSalir_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}
