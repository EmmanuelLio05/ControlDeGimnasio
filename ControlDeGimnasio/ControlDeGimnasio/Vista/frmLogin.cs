﻿using System;
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
using ControlDeGimnasio.Properties;

namespace ControlDeGimnasio.Vista {
    public partial class frmLogin : Form {
        Entidades.Usuario oUsuario;
        Datos.Usuario oDUsuario = new Datos.Usuario();

        public frmLogin() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){
            try {
                if (Validar()) {
                    oUsuario = oDUsuario.Login(txtUser.Text.Trim(), txtPass.Text.Trim());
                    if (oUsuario != null) {
                        Settings.Default.NombreUsuario = oUsuario.Nombre;
                        Settings.Default.NumeroUsuario = oUsuario.ID;
                        Settings.Default.TipoUsuario = oUsuario.Tipo;
                        this.DialogResult = DialogResult.OK;
                    } else {
                        MessageBox.Show("Usuario o contraseña incorrecta.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("error:" + ex.Message, "frmLogin_Load", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e){
            

        }

        private bool Validar() {
            if (txtUser.Text != null) {
                if (!(txtUser.Text.Trim().Length > 0)) {
                    MessageBox.Show("Indique el usuario.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            } else {
                MessageBox.Show("Indique el usuario.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPass.Text != null) {
                if (!(txtPass.Text.Trim().Length > 0)) {
                    MessageBox.Show("Indique la contraseña.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            } else {
                MessageBox.Show("Indique la contraseña.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnRegistros_Click(object sender, EventArgs e) {
            frmInOut f = new frmInOut();
            this.Visible = false;
            if (f.ShowDialog() != f.DialogResult) {
                this.Visible = true;
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e) {
            
        }
    }
}
