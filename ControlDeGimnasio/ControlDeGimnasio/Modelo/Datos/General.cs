using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeGimnasio.Modelo.Datos {
    class General {
        public SqlConnection Conectar() {
            SqlConnection sConnect = new SqlConnection();
            string sServidor;
            string sBD;

            try {
                sServidor = "AFRODITA";
                sBD = "MundoDeDonas";
                sConnect = new SqlConnection(@"Data Source=" + sServidor + ";Initial Catalog=" + sBD + ";Persist Security Info=True;User ID=Cliente;Password=cliente12345");
            } catch (Exception ex) {

            }
            return sConnect;
        }
    }
}
