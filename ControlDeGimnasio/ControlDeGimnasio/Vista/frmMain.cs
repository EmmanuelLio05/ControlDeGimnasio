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
    public partial class frmMain : Form {

        #region Metodos
        public frmMain() {
            InitializeComponent();
        }

        private void AgregarToolTips() {
            ToolTip ttAux = new ToolTip();

            ttAux.AutoPopDelay = 5000;
            ttAux.InitialDelay = 1000;
            ttAux.ReshowDelay = 500;
            ttAux.SetToolTip(this.btnSocios, "Catalogo de socios");
            ttAux.SetToolTip(this.btnAparatos, "Catalogo de aparatos");
            ttAux.SetToolTip(this.btnClases, "Catalogo de Clases");
            ttAux.SetToolTip(this.btnUsuarios, "Catalogo de usuarios");
            ttAux.SetToolTip(this.btnReportes, "Reportes");
            ttAux.SetToolTip(this.btnAbout, "Acerca de...");
            ttAux.SetToolTip(this.btnLogout, "Salir");

        }
        #endregion

        #region Eventos
        private void frmMain_Load(object sender, EventArgs e) {
            AgregarToolTips();
        }

        private void button4_Click(object sender, EventArgs e) {
            frmAparatoCat f = new frmAparatoCat();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            frmUsuarioCat f = new frmUsuarioCat();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {
            frmSociosCat f = new frmSociosCat();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            frmClaseCat f = new frmClaseCat();
            f.ShowDialog();
        }

        private void btnOfertas_Click(object sender, EventArgs e) {
            
        }

        private void button5_Click(object sender, EventArgs e) {

        }

        private void button6_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion
    }
}
