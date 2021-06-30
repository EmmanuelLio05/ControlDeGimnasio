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
            string sSql = "";

            try {

            } catch (Exception ex) { 

            }
        }
        #endregion

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e) {
            BusquedaRegistros();
        }

        private void frmReportes_Load(object sender, EventArgs e) {

        }

        private void frmReportes_KeyDown(object sender, KeyEventArgs e) {

        }

        private void tsbSalir_Click(object sender, EventArgs e) {

        }
        #endregion
    }
}
